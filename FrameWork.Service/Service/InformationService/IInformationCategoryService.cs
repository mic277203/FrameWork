using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Service
{
    public interface IInformationCategoryService
    {
        List<tbl_sys_infomationcategory> GetPage();
        void Add(tbl_sys_infomationcategory tbl_sys_infomationcategory);
        void Edit(tbl_sys_infomationcategory tbl_sys_infomationcategory);
        void Delete(tbl_sys_infomationcategory tbl_sys_infomationcategory);
        tbl_sys_infomationcategory Get(string id);
        void SaveChanges();
    }
}
