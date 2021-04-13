using System;

namespace OOP3
{
    class DosyaLogServisi : ILoglamaServisi
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}