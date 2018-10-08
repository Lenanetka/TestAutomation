using System;

namespace TestAutomation.Report
{
    class InitialReport
    {
        private static Report report;
        private static Object thisLock = new Object();
        public Report getInstance()
        {
            if (report == null)
            {
                lock (thisLock)
                {
                    if (report == null)
                    {
                        report = new ReportHTML("report.html");
                    }
                }
            }
            return report;
        }
    }
}
