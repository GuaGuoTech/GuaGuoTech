using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinModels
{
    public class Guest
    {
        private int id;
        private string name;
        private string weixin_num;
        private int age;
        private int sex;
        private string phone_num;
        private int star;

        public int Star
        {
            get { return star; }
            set { star = value; }
        }

        public string Phone_num
        {
            get { return phone_num; }
            set { phone_num = value; }
        }

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Weixin_num
        {
            get { return weixin_num; }
            set { weixin_num = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}