namespace Model
{

  public interface IOperations
  {
    
    void LoadDoctors();
    
    void LoadDoctorById();
    
    void LoadPatientById();
    
    void LoadAppointmentsHistory();

    void LoadFutureAppointments();
    
  }
}
