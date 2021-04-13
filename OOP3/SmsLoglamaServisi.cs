using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoglamaServisi :ILoglamaServisi
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
