﻿namespace Doctors.Infrastructure
{
    using Dapper;
    using Doctors.Domain.DoctorAggregate;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DoctorsRepository : IDoctorsRepository
    {

        public DoctorsRepository()
        {
        }

        public async Task AddDoctorAsync(Doctor doctor)
        {
            const string getAddedRowIdQueryQuery = @"SELECT CAST(SCOPE_IDENTITY() as int)";

            //utworzenie połączenia do bazy danych, klauzula using wykorzystywana jest żebyśmy nie musieli przejmować się zamykaniem polączenia
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                //otwarcie połączenia 
                dbConnection.Open();

                //utworzenie transakcji - będziemy wstawiać dane do trzech różnych tabel
                using (DbTransaction transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        const string insertDoctorQuery = @"INSERT INTO Doctor (PESEL,Name,Surname,Sex,BirthDate,City,Street,HouseNr) VALUES (@PESEL,@name, @Surname, @Sex, @BirthDate, @City, @Street, @HouseNr);";
                        //wykonanie zapytania sql, korzystamy tutaj z Dappera - pakietu ułatwiającego korzystanie z baz danych
                        int doctorId = await dbConnection.QueryFirstAsync<int>(insertDoctorQuery + ";" + getAddedRowIdQueryQuery, new { PESEL = doctor.PESEL, name = doctor.Name, Surname = doctor.Surname, Sex= doctor.Sex, BirthDate=doctor.BirthDate, City = doctor.City, Street = doctor.Street, HouseNr = doctor.HouseNr }, transaction);  

                        var certificationsIds = new List<int>();

                        const string insertCertificationQuery = @"INSERT INTO Certification (Type, GrantedAt) VALUES (@type,@grantedAt);";
                        foreach (var certifition in doctor.Certifications)
                            certificationsIds.Add(await dbConnection.QueryFirstAsync<int>(insertCertificationQuery + ";" + getAddedRowIdQueryQuery, new { type = certifition.Type, grantedAt = certifition.GrantedAt }, transaction));

                        const string insertDoctorCertificationQuery = @"INSERT INTO DoctorCertification (DoctorId, CertificationId) VALUES (@doctorId,@certificationId);";
                        foreach (var certifitionId in certificationsIds)
                            await dbConnection.QueryAsync(insertDoctorCertificationQuery, new { doctorId = doctorId, certificationId = certifitionId }, transaction);
                        //commit transakcji
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {

                //otwarcie połączenia tym razem nie jest konieczne, Dapper zrobi to automatycznie w razie potrzeby
                //poprzednim razem otwarcia połączenia wymagało utworzenie transakcji
                const string selectDoctorCertificationQuery = @"SELECT * FROM DoctorCertification";

                var doctorsCertificates =  (await dbConnection.QueryAsync(selectDoctorCertificationQuery)).Select(x=> new { CertificationId = x.CertificationId, DoctorId = x.DoctorId });

                const string selectDoctorQuery = @"SELECT * FROM Doctor";

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorQuery);

                const string selectCertificationsQuery = @"SELECT * FROM Certification";

                var certifications = await dbConnection.QueryAsync<Certification>(selectCertificationsQuery);

                foreach (var doctor in doctors)
                {
                    var certificationsIdForGivenDoctor = doctorsCertificates.Where(x => x.DoctorId == doctor.Id).Select(x=>x.CertificationId);
                    var certificationsForGivenDoctor = certifications.Where(x => certificationsIdForGivenDoctor.Contains(x.CertificationId));
                    doctor.AddCertifications(certificationsForGivenDoctor);
                }
                return doctors;
            }
        }
        public async Task<IEnumerable<Doctor>> GetById(int doctorId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {

                //otwarcie połączenia tym razem nie jest konieczne, Dapper zrobi to automatycznie w razie potrzeby
                //poprzednim razem otwarcia połączenia wymagało utworzenie transakcji
                const string selectDoctorCertificationQuery = @"SELECT * FROM DoctorCertification";

                var doctorsCertificates = (await dbConnection.QueryAsync(selectDoctorCertificationQuery)).Select(x => new { CertificationId = x.CertificationId, DoctorId = x.DoctorId });

                 string selectDoctorQuery = String.Format(@"SELECT * FROM Doctor WHERE Id = {0}", doctorId);

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorQuery);

                const string selectCertificationsQuery = @"SELECT * FROM Certification";

                var certifications = await dbConnection.QueryAsync<Certification>(selectCertificationsQuery);

                foreach (var doctor in doctors)
                {
                    var certificationsIdForGivenDoctor = doctorsCertificates.Where(x => x.DoctorId == doctor.Id).Select(x => x.CertificationId);
                    var certificationsForGivenDoctor = certifications.Where(x => certificationsIdForGivenDoctor.Contains(x.CertificationId));
                    doctor.AddCertifications(certificationsForGivenDoctor);
                }
                return doctors;
            }
        }
        public async Task<IEnumerable<Doctor>> GetByCertificationType(int certificationType)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {

                //otwarcie połączenia tym razem nie jest konieczne, Dapper zrobi to automatycznie w razie potrzeby
                //poprzednim razem otwarcia połączenia wymagało utworzenie transakcji
                const string selectDoctorCertificationQuery = @"SELECT * FROM DoctorCertification";

                var doctorsCertificates = (await dbConnection.QueryAsync(selectDoctorCertificationQuery)).Select(x => new { CertificationId = x.CertificationId, DoctorId = x.DoctorId });

                string selectDoctorQuery = String.Format(@"SELECT * FROM Doctor WHERE Id IN (SELECT DoctorId FROM DoctorCertification WHERE CertificationId IN (Select Id FROM Certification WHERE Type = {0}))", certificationType);

                var doctors = await dbConnection.QueryAsync<Doctor>(selectDoctorQuery);

                string selectCertificationsQuery = @"SELECT * FROM Certification";

                var certifications = await dbConnection.QueryAsync<Certification>(selectCertificationsQuery);

                foreach (var doctor in doctors)
                {
                    var certificationsIdForGivenDoctor = doctorsCertificates.Where(x => x.DoctorId == doctor.Id).Select(x => x.CertificationId);
                    var certificationsForGivenDoctor = certifications.Where(x => certificationsIdForGivenDoctor.Contains(x.CertificationId));
                    doctor.AddCertifications(certificationsForGivenDoctor);
                }
                return doctors;
            }
        }
    }
}
