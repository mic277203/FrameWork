using FrameWork.Data;
using FrameWork.Data.Repository;
using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Service
{
    public class InformationService : IInformationService
    {
        private readonly IInformationRepository _InformationRepository;
        private readonly IUnitOfWork _unitOfWork;
        public InformationService(IInformationRepository informationRepository, IUnitOfWork unitOfWork)
        {
            _InformationRepository = informationRepository;
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<tbl_sys_information> GetBusoppinformations()
        {
            var categorys = _InformationRepository.GetAll();

            return categorys;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="busoppinformation"></param>
        public void Insert(tbl_sys_information busoppinformation)
        {
            _InformationRepository.Add(busoppinformation);
        }
        public void Update(tbl_sys_information busoppinformation)
        {
            _InformationRepository.Update(busoppinformation);
        }
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
