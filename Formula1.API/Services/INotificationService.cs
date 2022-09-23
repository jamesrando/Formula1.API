namespace Formula1.API.Services
{
    public interface INotificationService
    {
        void Send(string subject, string message);
    }
}