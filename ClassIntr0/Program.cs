using System;

namespace ClassIntr0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs _kurs1 = new Kurs();
            _kurs1.KursAdi = "Java";
            _kurs1.Egitmen = "Engin Demiroğ";
            _kurs1.IzlenmeOrani = 1;

            Kurs _kurs2 = new Kurs();
            _kurs2.KursAdi = "Java2";
            _kurs2.Egitmen = "Engin Demiroğ2";
            _kurs2.IzlenmeOrani = 2;

            Kurs _kurs3 = new Kurs();
            _kurs3.KursAdi = "Java3";
            _kurs3.Egitmen = "Engin Demiroğ3";
            _kurs3.IzlenmeOrani = 3;

          Kurs [] kurslar = new Kurs[]{_kurs1,_kurs2,_kurs3};

          foreach (var x in kurslar)
          {
              Console.WriteLine(x.KursAdi + " / " + x.Egitmen +" /  " + x.IzlenmeOrani);
          }

          Console.ReadLine();

        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        
    }
}
