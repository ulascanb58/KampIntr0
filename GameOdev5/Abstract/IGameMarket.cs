using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Entity;

namespace GameOdev5.Abstract
{
    interface IGameMarket
    {
        void Buy(Offers offer, Customer customer);
    }
}
