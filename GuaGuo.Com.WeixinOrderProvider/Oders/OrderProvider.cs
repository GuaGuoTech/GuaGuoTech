using GuaGuo.Com.WeixinModel.Orders;
using GuaGuo.Com.WeixinOrderProvider.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Oders
{
    public class OrderProvider
    {
        public static void AddOrder(Order order){
        using (EntityContext entityContext=new EntityContext())
        {
            entityContext.OrderS.Add(order);
            entityContext.SaveChanges();

        }
        }
    }
}