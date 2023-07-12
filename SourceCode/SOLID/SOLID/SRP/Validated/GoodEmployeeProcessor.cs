using SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Validated
{
    class GoodEmployeeProcessor
    {
        MyLogger logger;
        string log;
        public GoodEmployeeProcessor()
        {
            logger = new MyLogger();
        }

        public bool InsertEmployee(Employee model)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(model.Id);
                sb.AppendLine();
                sb.Append(model.FirstName);
                sb.AppendLine();
                sb.Append(model.LastName);
                sb.AppendLine();
                sb.Append(model.HireDate);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\EmployeeData.txt", log);

                sb = new StringBuilder();
                sb.Append("Employee Added : ");
                sb.AppendLine();
                sb.Append(model.FirstName).Append(" ").Append(model.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Mesajı : ");
                sb.AppendLine();
                sb.Append(ex.Message);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                return false;
            }
        }
    }
}
