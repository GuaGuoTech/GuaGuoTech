using GuaGuo.Com.WeixinOrderProvider.Guests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrder.Guests
{
    public static class GuestService
    {
        public static void AddGuest()
        {

            GuestProvider.AddGuest();
        
        }
    }
}