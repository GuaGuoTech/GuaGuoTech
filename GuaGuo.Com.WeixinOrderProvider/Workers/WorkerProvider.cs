using GuaGuo.Com.WeixinModels;
using GuaGuo.Com.WeixinOrderProvider.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Workers
{
    public class WorkerProvider
    {
        public static void AddWorker(Worker worker)
        {
            using (EntityContext entityContext = new EntityContext())
            {
                entityContext.WorkerS.Add(worker);
                entityContext.SaveChanges();


            }

        }      
    }
}