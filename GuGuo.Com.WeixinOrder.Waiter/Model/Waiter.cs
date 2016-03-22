using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuGuo.Com.WeixinOrder.Waiter
{
    /// <summary>
    /// Waiter 类的Model定义
    /// id 唯一标识
    /// name 服务员名称
    /// sex 服务员性别
    /// phone_num 服务员电话
    /// weixin_num 服务员微信号
    /// commit 对服务员的星级评价
    /// note  服务员的简介
    /// sfz_account 服务员的身份证号
    /// </summary>
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
        private string phone_num;

        public string Phone_num
        {
            get { return phone_num; }
            set { phone_num = value; }
        }
        private string weixin_num;

        public string Weixin_num
        {
            get { return weixin_num; }
            set { weixin_num = value; }
        }
        private string commit;

        public string Commit
        {
            get { return commit; }
            set { commit = value; }
        }
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        private string sfz_account;

        public string Sfz_account
        {
            get { return sfz_account; }
            set { sfz_account = value; }
        }
    }
}