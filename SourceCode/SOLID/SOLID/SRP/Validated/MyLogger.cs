using System;
using System.IO;
using System.Text;

namespace SOLID.SRP.Validated
{
    class MyLogger
    {
        public void LogFile(string filePath,string log)
        {
            File.WriteAllText(filePath, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date : ");
            sb.Append(DateTime.Now.ToShortDateString());
            sb.AppendLine();
            sb.Append("Information : ").Append(information);

            return sb.ToString();
        }
    }
}
