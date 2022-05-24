using Hangfire;
using System.Diagnostics;

namespace HangFire.Web.BackgroundJobs
{
    public class RecurringJobs
    {
        public static void ReportingJob()
        {
            Hangfire.RecurringJob.AddOrUpdate("emailreportjob1", () => EmailReport(), Cron.Daily());
        }
        public static void EmailReport()
        {
            Debug.WriteLine("The report sent via email.");
        }
    }
}
