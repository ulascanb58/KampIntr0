using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            Urun urun1 = new Urun();

            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 45;

            Urun urun2= new Urun();

            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 35;

            Urun[] urunler = new Urun[]{urun1,urun2};

            foreach (var uruns in urunler )
            {
                Console.WriteLine(uruns.Adi);
                Console.WriteLine(uruns.Fiyati);
                Console.WriteLine(uruns.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Karpuz","Yeşil",34);

            Console.ReadLine();


        }
    }
}
