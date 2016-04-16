using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinModels
{  /// <summary>
    /// 用户信息表
    /// </summary>
    [Table("guest_info")]
    public class User
    {
        /// <summary>
        /// 设置主键ID
        /// </summary>
        [Key]
        [Column("id", TypeName = "BIGINT")]
        public long Id { get; set; }

        /// <summary>
        /// 设置Id的级别
        /// </summary>
        [Column("id_class", TypeName = "INT")]
        public int IdClass { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column("name", TypeName = "VARCHAR")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 设置当前对象生日日期
        /// </summary>
        [Column("birth_date", TypeName = "DATE")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 设置当前对象注册日期
        /// </summary>
        [Column("login_date", TypeName = "DATE")]
        public DateTime LoginDate { get; set; }

        /// <summary>
        /// 当前对象联系电话
        /// </summary>
        [Column("phone_num", TypeName = "VARCHAR")]
        public string PhoneNum { get; set; }

        /// <summary>
        /// 当前对象联系微信
        /// </summary>
        [Column("weixin_num", TypeName = "VARCHAR")]
        [Required]
        public string WeixinNum { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Column("address", TypeName = "VARCHAR")]
        public string Address { get; set; }


        /// <summary>
        /// 当前对象性别 0女1男
        /// </summary>
        [Column("sex", TypeName = "INT")]
        public int Sex { get; set; }

        /// <summary>
        /// 当前对象星级
        /// </summary>
        [Column("star", TypeName = "INT")]
        public int Star { get; set; }

        
    }

}