namespace SmokeTestSelenium.Interface
{
    public interface IAppointment
    {
        Task AppointmentCreate(Int16 order, Int16 wait, String Test, Int16 Module);
    }
}
