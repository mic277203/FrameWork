using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Data
{
   
    public class InformationCategoryRepository : RepositoryBase<tbl_sys_infomationcategory>, IInformationCategoryRepository
    {
        public InformationCategoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IInformationCategoryRepository : IRepository<tbl_sys_infomationcategory>
    {

    }
}
