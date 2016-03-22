using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinModel.Orders
{
    [Table("weixinorder_order_info")]
    public class Order
    {    /// <summary>
        /// 设置主键Id
        /// </summary>
        [Key]
        [Column("id")]
        public long Id { get; set; }
       /// <summary>
       /// 下单用户的名称
       /// </summary>
        [Column("name")]
        public string Name { get; set; }
        /// <summary>
        /// 订餐的桌号
        /// </summary>
        [Column("table")]
        public int Table { get; set; }
        /// <summary>
        /// 下单的最早时间
        /// </summary>
        [Column("first_time")]
        public DateTime  FirstTime { get; set; }
        /// <summary>
        /// 餐品全部送达时间
        /// </summary>
        [Column("last_time")]
        public DateTime LastTime { get; set; }
        /// <summary>
        /// 当前订单总额
        /// </summary>
        [Column("money")]
        public int Money { get; set; }
        /// <summary>
        /// 是否加餐 
        /// </summary>
        [Column("add")]
        public int Add { get; set; }
        /// <summary>
        /// 是否开具发票 1是 0否 
        /// </summary>
        [Column("发票")]
        public Boolean Fapiao { get; set; }


      
    }
}