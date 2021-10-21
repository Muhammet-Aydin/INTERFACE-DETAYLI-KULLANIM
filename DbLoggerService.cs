using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DbLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("VeriTabanına Loglandı.");
        }
    }
}
