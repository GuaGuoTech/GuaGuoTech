using GuaGuo.Com.WeixinModels;
using GuaGuo.Com.WeixinOrderProvider.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Guests
{
    public static class GuestProvider
    {
        public  static  void  AddGuest()
        {
            using (EntityContext entityContext = new EntityContext())
            {
                Guest g = new Guest { 
                Age=1,
                Name="sdfa",
                Sex=1,
                Phone_num="dsaf",
                Star=3,
                Weixin_num="asdfdsf",
                };
                entityContext.GuestS.Add(g);
            
            }
        

        }
    }
}