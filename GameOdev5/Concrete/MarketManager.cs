using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Abstract;
using GameOdev5.Entity;

namespace GameOdev5.Concrete
{
    class MarketManager:IGameMarket
    {
       

       /* public void Buy(Offers offer)
        {
            if (offer.OfferStatus)
            {
                Console.WriteLine("Oyunu özel bir teklif ile aldınız " + offer.OfferType);
                
            }
            else
            {
                Console.WriteLine("Satın alma başarılı " +offer.OfferType);
            }
        }*/
       public void Buy(Offers offer, Customer customer)
       {
           if (offer.OfferStatus)
           {
               Console.WriteLine(customer.CustomerID + " Id'li müşteri " + offer.OfferType + " teklifi ile oyunu satın aldı.");
           }
           else
           {
               Console.WriteLine("Satın alma başarılı " + offer.OfferType);

            }
          
           
       }
    }
}
