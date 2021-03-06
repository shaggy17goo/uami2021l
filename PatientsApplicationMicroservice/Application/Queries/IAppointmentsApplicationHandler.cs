using PatientsApplicationMicroservice.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.Queries
{
    public interface IAppointmentsApplicationHandler
    {
        Task<List<AppointmentWithNamesDto>> GetAppointmentsHistory(int patientId);
        Task<List<AppointmentWithNamesDto>> GetFutureAppointments(int patientId);
    }
}
