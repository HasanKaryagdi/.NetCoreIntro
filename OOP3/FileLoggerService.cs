using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {//İmplament edildi
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}