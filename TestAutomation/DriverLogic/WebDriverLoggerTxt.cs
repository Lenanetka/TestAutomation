using System.IO;

namespace TestAutomation.DriverLogic
{
    public class WebDriverLoggerTxt : WebDriverLogger
    {
        private string path;
        public WebDriverLoggerTxt(string path)
        {
            this.path = path;
            if (!File.Exists(path)) File.CreateText(path);
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
