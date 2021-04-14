using System;
using GameOdev5.Concrete;
using GameOdev5.Entity;

namespace GameOdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            
            Customer musteri1=new Customer();
            musteri1.FirstName = "Ulaş";
            musteri1.CustomerID = 1;
            musteri1.LastName = "Bozkurt";
            musteri1.IdentityNumber = "1111111";
            musteri1.DateOfBirth= new DateTime(1997);

            Customer musteri2 = new Customer();
            musteri2.FirstName = "Can";
            musteri2.CustomerID = 2;
            musteri2.LastName = "Bozkurt";
            musteri2.IdentityNumber = "2222222";
            musteri2.DateOfBirth = new DateTime(1998);

            Customer musteri3 = new Customer();
            musteri3.FirstName = "Haydar";
            musteri3.CustomerID = 3;
            musteri3.LastName = "Bozkurt";
            musteri3.IdentityNumber = "333333";
            musteri3.DateOfBirth = new DateTime(1999);

            customerManager.Update(musteri1);
            customerManager.Delete(musteri2);
            customerManager.Register(musteri3);

            Console.WriteLine("------------");


            Offers offer1=new Offers();
            offer1.OfferID = 1;
            offer1.OfferType = "İskonto 1";
            offer1.OfferStatus = true;

            Offers offer2 = new Offers();
            offer2.OfferID = 2;
            offer2.OfferType = "İskonto 2";
            offer2.OfferStatus = true;

            Offers offer3 = new Offers();
            offer3.OfferID = 3;
            offer3.OfferType = "İskontosuz";
            offer3.OfferStatus = false;

            OfferManager offerManager = new OfferManager();
            offerManager.NewOffer(offer1);
            offerManager.UpdateOffer(offer2);
            offerManager.DeleteOffer(offer3);
            offerManager.DeleteOffer(offer1);
            offerManager.DeleteOffer(offer2);

            Console.WriteLine("------------");

            MarketManager marketManager = new MarketManager();
            marketManager.Buy(offer1,musteri1);
            marketManager.Buy(offer2,musteri2);


            marketManager.Buy(offer3,musteri3);



            Console.ReadLine();
        }
    }
}
