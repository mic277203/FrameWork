using FrameWork.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Data
{
    public class FrameWorkEntities : IdentityDbContext
    {
        public FrameWorkEntities()
            : base("FrameWorkEntities")
        {
        }

        public DbSet<busoppinformation> tbl_sys_busoppinformation { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 还可以移除对MetaData表的查询验证
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Configurations.Add(new BusoppinformationConfiguration());

        }
    }
}
