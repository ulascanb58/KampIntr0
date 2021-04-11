using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi");
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.StokAdedi);

        }

        public void Ekle2(string urunAdi, string aciklama, int fiyat)

        {
            Console.WriteLine(" Tebrikelr sepete eklendi" +urunAdi);
            

        }
    }
}
