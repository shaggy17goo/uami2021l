using Microsoft.VisualBasic.CompilerServices;
using PatientsData.Domain.PatientAggregate;

namespace PatientsData.Infrastructure
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PatientsRepository : IPatientsRepository
    {

        public void AddPatientAsync(Patient patient)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string getMaxIdQuery = @"SELECT max(patientId) FROM patients";
                
                var maxId = dbConnection.QueryAsync<int>(getMaxIdQuery).Result.First();

                const string insertPatientQuery = @"INSERT INTO patients (patientId, PESEL, name, surname, sex, birthDate, city, street, houseNr)
                                                        VALUES (@patientId, @PESEL, @name, @surname, @sex, @birthDate, @city, @street, @houseNr);";
                    
                dbConnection.QueryAsync(insertPatientQuery , new {patientId=maxId + 1, patient.PESEL, patient.name, patient.surname, patient.sex, patient.birthDate, patient.city, patient.street, patient.houseNr});
                    
            }
        }

        public async Task<IEnumerable<Patient>> listPatients()
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = @"SELECT * FROM patients";

                var patients = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);
                
                return patients;
            }
        }

        public async Task<Patient> GetPatientById(int patientId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = String.Format(@"SELECT * FROM patients WHERE patientId = {0}", patientId);

                var patient = await dbConnection.QueryAsync<Patient>(selectPatientsQuery);
                
                return patient.First();
                
            }
        }

        public async Task<Patient> GetPatientByPESEL(string PESEL)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = String.Format(@"SELECT * FROM patients WHERE pesel = {0}", PESEL);

                var patient =  await dbConnection.QueryAsync<Patient>(selectPatientsQuery);
                
                return patient.First();
                
            }
        }
        
        public void DeletePatientAsync(int patientId, string pesel)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string deletePatient = @"DELETE FROM patients WHERE patientId=@patientID AND pesel=@pesel";
                
                dbConnection.QueryAsync(deletePatient , new {patientId, pesel});
      
            }
        }
    }
}
