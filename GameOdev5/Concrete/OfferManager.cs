using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Abstract;
using GameOdev5.Entity;

namespace GameOdev5.Concrete
{
    class OfferManager:INewOffer
    {
        public void NewOffer(Offers offer)
        {
            Console.WriteLine("Yeni kampanya oluşturuldu, kampanya Adı :"+offer.OfferType);
            if (offer.OfferStatus == true)
            {
                Console.WriteLine("Kampanyanın durumu : aktif");

            }
            else
            {
                Console.WriteLine("Kampanyanın durumu pasif");
            }
          
        }

        public void DeleteOffer(Offers offer)
        {
            offer.OfferStatus = Convert.ToBoolean(false);
            if (offer.OfferStatus == false)
            {
                Console.WriteLine(offer.OfferID + " Id li kampanyanın durumu : pasif");
            }
            else
            {
                Console.WriteLine("Kampanya aktif");
            }

            
           
        }

        public void UpdateOffer(Offers offer)
        {
           Console.WriteLine(offer.OfferID + " Id li kampanya güncellenmiştir.");
        }
    }
}
