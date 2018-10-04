namespace TestAutomation.Report
{
    public abstract class Logger
    {
        public delegate void OnLog(bool positive, string action, string message);
        public event OnLog LogEvent;
        protected void log(bool positive, string action, string message)
        {
            LogEvent(positive, action, message);
        }
    }
}
