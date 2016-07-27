using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Data.Repository
{
    public class BusoppinformationRepository : RepositoryBase<busoppinformation>, IBusoppinformationRepository
    {
        public BusoppinformationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IBusoppinformationRepository : IRepository<busoppinformation>
    {

    }
}
