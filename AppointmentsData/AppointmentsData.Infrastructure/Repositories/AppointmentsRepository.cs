
namespace AppointmentsData.Infrastructure.Repositories
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualBasic.CompilerServices;
    using AppointmentsData.Domain.PatientAggregate;

    public class AppointmentsRepository : IAppointmentsRepository
    {

        public async Task<IEnumerable<Appointment>> ListAppointments()
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = @"SELECT * FROM appointments";

                var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);
                
                return appointments;
            }
        }
        
        public async Task<IEnumerable<Appointment>> ListDoctorAppointments(int doctorId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = String.Format(@"SELECT * FROM appointments WHERE doctorId = {0}", doctorId);

                var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);
                
                return appointments;
            }
        }
        
        public async Task<IEnumerable<Appointment>> ListPatientAppointments(int patientId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = String.Format(@"SELECT * FROM appointments WHERE patientId = {0}", patientId);

                var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);
                
                return appointments;
            }
        }
        
        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                string selectPatientsQuery = String.Format(@"SELECT * FROM appointments WHERE appointmentId = {0}", appointmentId);

                var patient = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);
                
                return patient.First();
                
            }
        }
        public void AddAppointmentAsync(Appointment appointment)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                const string getMaxIdQuery = @"SELECT max(appointmentId) FROM appointments";
                
                var maxId = dbConnection.QueryAsync<int>(getMaxIdQuery).Result.First();

                const string insertPatientQuery = @"INSERT INTO appointments (appointmentId, doctorId, patientId, dateOfAppointment, description)
                                                        VALUES (@appointmentId, @doctorId, @patientId, @dateOfAppointment, @description);";
                    
                dbConnection.QueryAsync(insertPatientQuery , new {appointmentId=maxId + 1, doctorId = appointment.doctorId, patientId = appointment.patientId, dateOfAppointment = appointment.dateOfAppointment, description = appointment.description});
                    
            }
        }
        

        public void DeleteAppointmentAsync(int commandAppointmentId)
        {
            using (var dbConnection = new SqlConnection(Constants.connectionString))
            {
                const string deleteAppointment = @"DELETE FROM appointments WHERE appointmentId=@appointmentId";
                
                dbConnection.QueryAsync(deleteAppointment , new{appointmentId = commandAppointmentId});
      
            }
        }
    }
}
