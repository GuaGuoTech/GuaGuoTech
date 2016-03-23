using GuaGuo.Com.WeixinModel.Waiters;
using GuaGuo.Com.WeixinOrderProvider.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Waiters
{
    public class WaiterProvider
    { public static  void  AddWiater(Waiter waiter)
    {
        using (EntityContext entityContext = new EntityContext()) 
        {

            entityContext.WaiterS.Add(waiter);
            entityContext.SaveChanges();
        }

     }
    }
}