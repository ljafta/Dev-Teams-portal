using EndToEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EndToEnd.Models
{

    public partial class DevContext : DbContext
    {
        public DevContext()
            : base("DefaultConnection")
        // : base ("name=masterEntities")
        {
        }

        public static DevContext Create()
        {
            return new DevContext();
        }

        public virtual DbSet<Groups> Groups { get; set; }
    }
}