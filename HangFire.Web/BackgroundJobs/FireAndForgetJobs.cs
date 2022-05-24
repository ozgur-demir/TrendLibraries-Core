using HangFire.Web.Services;

namespace HangFire.Web.BackgroundJobs
{
    public class FireAndForgetJobs
    {

        public static void  EmailSendToUserJob(string userID, string msg)
        {
            Hangfire.BackgroundJob.Enqueue<IEmailSender>(x => x.Sender(userID, msg));
        }
    }
}
