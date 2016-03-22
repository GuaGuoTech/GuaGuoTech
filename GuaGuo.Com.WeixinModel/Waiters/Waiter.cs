using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinModel.Waiters
{
    [Table("weixinorder_waiter_info")]
    public class Waiter
    {  /// <summary>
        /// 设置主键ID
        /// </summary>
        [Key]
        [Column("id")]
        public long Id { get; set; }
        /// <summary>
        /// 设置Id的级别
        /// </summary>
        [Column("id_class")]
        public int IdClass { get; set; }
        /// <summary>
        /// 设置登录密码
        /// </summary>
        [Column("password")]
        public int Password { get; set; }
        /// <summary>
        /// 当前对象联系电话
        /// </summary>
        [Column("phone_num")]
        public string PhoneNum { get; set; }
        /// <summary>
        /// 当前对象联系微信
        /// </summary>
        [Column("weixin_num")]
        public string WeixinNum { get; set; }
        /// <summary>
        /// 当前对象身份证号码
        /// </summary>
        [Column("sfz_account")]
        public int SfzAccount { get; set; }
        /// <summary>
        /// 当前对象的简介
        /// </summary>
        [Column("note")]
        public string Note { get; set; }
        /// <summary>
        /// 当前对象性别 0女1男
        /// </summary>
        [Column("sex")]
        public Boolean Sex { get; set; }
        /// <summary>
        /// 当前对象星级
        /// </summary>
        [Column("star")]
        public int Star { get; set; }

    }
}