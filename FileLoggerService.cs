using System;

namespace ConsoleApp4
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}
