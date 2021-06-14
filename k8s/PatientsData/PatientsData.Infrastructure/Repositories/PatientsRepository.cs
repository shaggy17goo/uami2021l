namespace PatientsData.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using Dapper;
    using Domain.PatientAggregate;

    public class PatientsRepository : IPatientsRepository
    {
        public int AddPatientAsync(Patient patient)
        {
            using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string getMaxIdQuery = @"SELECT NEXT VALUE FOR patientIdSeq;";

            var maxId = dbConnection.QueryAsync<int>(getMaxIdQuery).Result.First();

            const string insertPatientQuery =
                @"INSERT INTO patients (patientId, PESEL, name, surname, sex, birthDate, city, street, houseNr)
                                                        VALUES (@patientId, @PESEL, @name, @surname, @sex, @birthDate, @city, @street, @houseNr);";

            dbConnection.QueryAsync(insertPatientQuery,
                new
                {
                    patientId = maxId,
                    PESEL = patient.pesel, patient.name, patient.surname, patient.sex,
                    patient.birthDate, patient.city, patient.street, patient.houseNr
                });

            return maxId;
        }

        public async Task<IEnumerable<Patient>> listPatients()
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string selectPatientsQuery = @"SELECT * FROM patients";

            var patients = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

            return patients;
        }

        public async Task<Patient> GetPatientById(int patientId)
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            var selectPatientsQuery = $@"SELECT * FROM patients WHERE patientId = {patientId}";

            var patient = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

            return patient.First();
        }

        public async Task<Patient> GetPatientByPESEL(string pesel)
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            var selectPatientsQuery = $@"SELECT * FROM patients WHERE pesel = '{pesel}'";

            var patient = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);

            return patient.First();
        }

        public int DeletePatientAsync(int patientId, string pesel)
        {
            using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string deletePatient = @"DELETE FROM patients WHERE patientId=@patientID AND pesel=@pesel";

            dbConnection.Query(deletePatient, new {patientId, pesel});

            return 0;
        }
    }
}