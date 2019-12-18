using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log : ILog
    {
        
        // below is example of eager loading , when object is available before it is use //
        //private static readonly Singleton instance = new Singleton();


        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());



        public static Log getInstance
        {
            get
            {
                return instance.Value;
            }
        }

        /*  
         *  Private COnstructor ensures that Object is not instantiated other than with in the class itself
         *  */

        private Log()
        {
            
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.txt", "Exception", "12152019");
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
