using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoglamaServisi> loglamaServisi)
        {
            //Başvuran bilgilerini değerlendirme

            krediManager.Hesapla();
            foreach (var item in loglamaServisi)
            {   
                item.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler,List<ILoglamaServisi> loglamaServisi)
        {

            foreach (var kredi in krediler)
            {   
                kredi.Hesapla();
               
            }

            foreach (var items in loglamaServisi)
            {
                items.Log();
            }
        }
    }
}
