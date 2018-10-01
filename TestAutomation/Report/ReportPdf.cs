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
    class ToReport : IReportSource
    {
        public ReportFieldCollection GetFields()
        {
            throw new System.NotImplementedException();
        }

        public object GetFieldValue(object dataItem, string fieldName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable GetItems()
        {
            throw new System.NotImplementedException();
        }
    }
    class ReportPdf: SeleniumWebDriverLogger
    {
        private string path;
        public ReportPdf(string path)
        {
            this.path = path;
            if (!File.Exists(path)) File.CreateText(path);
        }
        public override void writeLine(string line)
        {
            List<string> query = new List<string>();
            query.Add("Test!");
            var report = new Report(query.ToReportSource());
            using (FileStream sw = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, sw);
                doc.Open();
                doc.Add(new Paragraph("Hello World"));
                doc.Close();
                PdfReader reader = new PdfReader(path);
                string text = string.Empty;
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    text += line;
                }
                reader.Close();
            }
        }
    }
}
