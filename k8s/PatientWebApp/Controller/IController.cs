using Model;

namespace Controller
{
    using System.ComponentModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public interface IController : INotifyPropertyChanged
    {
        IModel Model { get; }

        Task GetDoctorsAsync();

        Task GetDoctorByIdAsync();

        Task GetPatientByIdAsync();

        Task GetAppointmentsHistoryAsync();

        Task GetFutureAppointmentsAsync();

        
    }
}