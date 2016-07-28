using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameWork.Data;
using FrameWork.Model;

namespace FrameWork.Service
{
    public class InformationCategoryService : IInformationCategoryService
    {
        private readonly IInformationCategoryRepository _InformationCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public InformationCategoryService(IInformationCategoryRepository informationCategoryRepository, IUnitOfWork unitOfWork)
        {
            _InformationCategoryRepository = informationCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public List<tbl_sys_infomationcategory> GetPage()
        {
            var list = new List<tbl_sys_infomationcategory>()
            {
                new tbl_sys_infomationcategory() { id="1",name="行业资讯",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="2",name="评论预测",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="3",name="技术文章",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="4",name="政策法规",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="5",name="国内财经",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="6",name="国际财经",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="7",name="企业新闻",createdate=DateTime.Now},
                new tbl_sys_infomationcategory() { id="7",name="微信推送",createdate=DateTime.Now}
        };

            return list;
        }
        public void Add(tbl_sys_infomationcategory tbl_sys_infomationcategory)
        {
            _InformationCategoryRepository.Add(tbl_sys_infomationcategory);
        }
        public void Edit(tbl_sys_infomationcategory tbl_sys_infomationcategory)
        {
            _InformationCategoryRepository.Update(tbl_sys_infomationcategory);
        }
        public void Delete(tbl_sys_infomationcategory tbl_sys_infomationcategory)
        {
            _InformationCategoryRepository.Delete(tbl_sys_infomationcategory);
        }
        public tbl_sys_infomationcategory Get(string id)
        {
            _InformationCategoryRepository.GetById(id);

            return GetPage().FirstOrDefault(p => p.id == id);
        }
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
