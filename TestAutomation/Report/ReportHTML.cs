using System.IO;

namespace TestAutomation.Report
{
    class ReportHTML: Report
    {
        private string path;
        public ReportHTML(string path)
        {
            this.path = path;
            if (!File.Exists(path)) File.CreateText(path);
        }      
    }
}
