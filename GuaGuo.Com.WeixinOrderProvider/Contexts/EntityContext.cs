﻿using GuaGuo.Com.WeixinModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuaGuo.Com.WeixinOrderProvider.Contexts
{
    public class EntityContext:DbContext
    {
        public EntityContext() : base("name=EntityContext") { }

        public DbSet<Guest> GuestS { get; set; }
    }
}