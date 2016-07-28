using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Service
{
    public interface IInformationService
    {
        IEnumerable<tbl_sys_information> GetBusoppinformations();
        void Insert(tbl_sys_information busoppinformation);
        void Update(tbl_sys_information busoppinformation);

        void SaveChanges();
    }
}
