using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Data
{
    public class BusoppinformationConfiguration : EntityTypeConfiguration<tbl_sys_information>
    {
        public BusoppinformationConfiguration()
        {
            Property(p => p.title).HasMaxLength(50);
        }
    }
}
