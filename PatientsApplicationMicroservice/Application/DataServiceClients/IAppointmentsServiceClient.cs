using PatientsApplicationMicroservice.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatientsApplicationMicroservice.Application.DataServiceClients
{
    public interface IAppointmentsServiceClient
    {
        Task<IEnumerable<AppointmentDto>> GetAppointmentsByPatientId(int patientId);
    }

}
