using Model;

namespace Controller
{
    using System.Threading.Tasks;
    using Utilities;

    public class Controller : PropertyContainerBase, IController
    {
        public IModel Model { get; }

        public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
        {
            Model = model;
        }

        public async Task GetDoctorsAsync()
        {
            await Task.Run(GetDoctors);
        }
        
        
        public async Task GetDoctorByIdAsync()
        {
            await Task.Run(GetDoctorById);
        }
        
        public async Task GetPatientByIdAsync()
        {
            await Task.Run(GetPatientById);
        }
        
        public async Task GetAppointmentsHistoryAsync()
        {
            await Task.Run(GetAppointmentsHistory);
        }
        
        public async Task GetFutureAppointmentsAsync()
        {
            await Task.Run(GetFutureAppointments);
        }
        
        
        
        private void GetDoctors()
        {
            Model.LoadDoctors();
        }
        
        private void GetDoctorById()
        {
            Model.LoadDoctorById();
        }
        
        private void GetPatientById()
        {
            Model.LoadPatientById();
        }
        
        private void GetAppointmentsHistory()
        {
            Model.LoadAppointmentsHistory();
        }
        
        private void GetFutureAppointments()
        {
            Model.LoadFutureAppointments();
        }
        
        
        
        
    }
}