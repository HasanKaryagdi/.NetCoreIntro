using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    
    class DatabaseLoggerService : ILoggerService
    {//İmplament edildi
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
