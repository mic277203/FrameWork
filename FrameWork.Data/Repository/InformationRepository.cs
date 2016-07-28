using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Data.Repository
{
    public class InformationRepository : RepositoryBase<tbl_sys_information>, IInformationRepository
    {
        public InformationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IInformationRepository : IRepository<tbl_sys_information>
    {

    }
}
