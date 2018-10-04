using System.Collections;
using System.Collections.Generic;
using System.IO;
using DoddleReport;
using DoddleReport.Writers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TestAutomation.DriverLogic;

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
