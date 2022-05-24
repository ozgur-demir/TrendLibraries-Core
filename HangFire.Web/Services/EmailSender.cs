namespace HangFire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        public Task Sender(string email, string message)
        {
            return Task.CompletedTask;
        }
    }
}
