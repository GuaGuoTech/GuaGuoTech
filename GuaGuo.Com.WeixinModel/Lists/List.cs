using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinModel.List
{
    [Table("list_info")]
    public class List
    {    /// <summary>
        /// 设置主键Id
        /// </summary>
        [Key]
        [Column("id",TypeName="BIGINT")]
        public long Id { get; set; }

        /// <summary>
        /// 下单用户的名称
        /// </summary>
        [Column("name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        /// <summary>
        /// 订餐的桌号
        /// </summary>
        [Column("table", TypeName = "INT")]
        public int Table { get; set; }

        /// <summary>
        /// 菜品准备时间
        /// </summary>
        [Column("ready_time", TypeName = "DATE")]
        public DateTime ReadyTime { get; set; }

        /// <summary>
        /// 餐品全部送达时间
        /// </summary>
        [Column("all_time", TypeName = "DATE")]
        public DateTime AllTime { get; set; }

        /// <summary>
        /// 当前订单总额
        /// </summary>
        [Column("money", TypeName = "INT")]
        public int Money { get; set; }

        /// <summary>
        /// 当前对象分类
        /// </summary>
        [Column("classify", TypeName = "INT")]
        public int Classify { get; set; }

        /// <summary>
        /// 月销量
        /// </summary>
        [Column("monthsale", TypeName = "INT")]
        public int MonthSale { get; set; }

        /// <summary>
        /// 当前菜品的评价
        /// </summary>
        [Column("comment", TypeName = "NVARCHAR")]
        public string Comment { get; set; }

        /// <summary>
        /// 当前菜品的图片路径
        /// </summary>
        [Column("pic", TypeName = "NVARCHAR")]
        public string Pic { get; set; }

        /// <summary>
        /// 当前对象的推荐等级  0无1有
        /// </summary>
        [Column("advertise", TypeName = "INT")]
        public int Advertise { get; set; }

        /// <summary>
        /// 当前菜品的折扣1
        /// </summary>
        [Column("discount1", TypeName = "DOUBLE")]
        public double Discount1 { get; set; }

        /// <summary>
        /// 当前菜品的折扣2
        /// </summary>
        [Column("discount2", TypeName = "DOUBLE")]
        public double Discount2  { get; set; }

        /// <summary>
        /// 当前菜品的折扣3
        /// </summary>
        [Column("discount3", TypeName = "DOUBLE")]
        public double Discount3 { get; set; }

        
    }

}