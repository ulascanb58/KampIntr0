using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.MusteriAdi = "Engin";
            musteri1.MusteriSoyadi = "Demiroğ";
            musteri1.TcNo = "11111111111";

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1000000000";

            Musteri musteri3=new GercekMusteri();
            Musteri musteri4=new TuzelMusteri();

            MusteriManager _musteriManager = new MusteriManager();
            _musteriManager.Ekle(musteri1);
            _musteriManager.Ekle(musteri2);
            _musteriManager.Ekle(musteri3);
            _musteriManager.Ekle(musteri4);



        }
    }
}
