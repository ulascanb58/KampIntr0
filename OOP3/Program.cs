using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();
         

            IKrediManager tasitKrediManager=new TasitKrediManager();
           

            IKrediManager konutKrediManager = new KonutKrediManager();
          
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            ILoglamaServisi veriLoglamaServisi = new VeritabaniLogServisi();
            ILoglamaServisi dosyLoglamaServisi = new DosyaLogServisi();
            ILoglamaServisi smsServisi =new SmsLoglamaServisi();
            BasvuruManager basvuruManager = new BasvuruManager();

            List<ILoglamaServisi> loglar = new List<ILoglamaServisi>(){dosyLoglamaServisi,veriLoglamaServisi,smsServisi};
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loglar);
            Console.WriteLine("--------------");
           List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager,tasitKrediManager,konutKrediManager,esnafKrediManager};
    
           basvuruManager.KrediOnBilgilendirmesiYap(krediler,loglar);
            Console.ReadLine();
        }
    }
}
