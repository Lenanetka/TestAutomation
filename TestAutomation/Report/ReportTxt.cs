using System.IO;
using TestAutomation.DriverLogic;

namespace TestAutomation.Report
{
    class ReportTxt : SeleniumWebDriverLogger
    {
        private string path;
        public ReportTxt(string path)
        {
            this.path = path;
            if (!File.Exists(path)) File.CreateText(path);
        }
        public string getCurrentTime()
        {
            return System.DateTime.Now.ToString("[dd/MM/yyyy hh:mm:ss]: ");
        }
        public override void writeLine(string line)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(getCurrentTime() + line);
            }
        }
    }
}
