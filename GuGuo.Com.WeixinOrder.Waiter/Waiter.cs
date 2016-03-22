using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuGuo.Com.WeixinOrder.Waiter
{
    public class Waiter
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool sex;

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string Phonenum;

        public string Phonenum1
        {
            get { return Phonenum; }
            set { Phonenum = value; }
        }
        private string othernum;

        public string Othernum
        {
            get { return othernum; }
            set { othernum = value; }
        }
    }
}