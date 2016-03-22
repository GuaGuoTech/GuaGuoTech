using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuGuo.Com.WeixinOrder.Waiter
{
    public class OrderSercices
    {
        private int id;
        private string list;
        

        public string List
        {
            get { return list; }
            set { list = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}