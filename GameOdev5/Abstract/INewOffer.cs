using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Entity;

namespace GameOdev5.Abstract
{
    public interface INewOffer
    {
        void NewOffer(Offers offer);
        void DeleteOffer(Offers offer);
        void UpdateOffer(Offers offer);
    }
}
