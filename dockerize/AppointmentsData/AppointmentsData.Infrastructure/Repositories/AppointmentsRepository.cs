using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AppointmentsData.Domain.PatientAggregate;
using Dapper;

namespace AppointmentsData.Infrastructure.Repositories
{
    public class AppointmentsRepository : IAppointmentsRepository
    {
        public async Task<IEnumerable<Appointment>> ListAppointments()
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string selectPatientsQuery = @"SELECT * FROM appointments";

            var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);

            return appointments;
        }

        public async Task<IEnumerable<Appointment>> ListDoctorAppointments(int doctorId)
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            var selectPatientsQuery = $@"SELECT * FROM appointments WHERE doctorId = {doctorId}";

            var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);

            return appointments;
        }

        public async Task<IEnumerable<Appointment>> ListPatientAppointments(int patientId)
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            var selectPatientsQuery = $@"SELECT * FROM appointments WHERE patientId = {patientId}";

            var appointments = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);

            return appointments;
        }

        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            await using var dbConnection = new SqlConnection(Constants.ConnectionString);
            var selectPatientsQuery = $@"SELECT * FROM appointments WHERE appointmentId = {appointmentId}";

            var patient = await dbConnection.QueryAsync<Appointment>(selectPatientsQuery);

            return patient.First();
        }

        public int AddAppointmentAsync(Appointment appointment)
        {
            using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string getMaxIdQuery = @"SELECT NEXT VALUE FOR appointmentIdSeq;";

            var maxId = dbConnection.QueryAsync<int>(getMaxIdQuery).Result.First();

            const string insertPatientQuery =
                @"INSERT INTO appointments (appointmentId, doctorId, patientId, dateOfAppointment, description)
                                                        VALUES (@appointmentId, @doctorId, @patientId, @dateOfAppointment, @description);";

            dbConnection.QueryAsync(insertPatientQuery, new
            {
                appointmentId = maxId, doctorId = appointment.DoctorId, patientId = appointment.PatientId,
                dateOfAppointment = appointment.DateOfAppointment,
                description = appointment.Description
            });

            return maxId;
        }


        public int DeleteAppointment(int commandAppointmentId)
        {
            using var dbConnection = new SqlConnection(Constants.ConnectionString);
            const string deleteAppointment = @"DELETE FROM appointments WHERE appointmentId=@appointmentId";

            dbConnection.Query(deleteAppointment, new {appointmentId = commandAppointmentId});

            return 0;
        }
    }
}