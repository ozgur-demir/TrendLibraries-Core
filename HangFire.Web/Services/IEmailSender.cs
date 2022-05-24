namespace HangFire.Web.Services
{
    public interface IEmailSender
    {
        Task Sender(string email,string message);
    }
}
