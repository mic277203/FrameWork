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
    public class BusoppinformationService : IBusoppinformationService
    {
        private readonly IBusoppinformationRepository _busoppinformationService;
        private readonly IUnitOfWork _unitOfWork;
        public BusoppinformationService(IBusoppinformationRepository busoppinformationRepository, IUnitOfWork unitOfWork)
        {
            _busoppinformationService = busoppinformationRepository;
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<busoppinformation> GetBusoppinformations()
        {
            var categorys = _busoppinformationService.GetAll();

            return categorys;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="busoppinformation"></param>
        public void Insert(busoppinformation busoppinformation)
        {
            _busoppinformationService.Add(busoppinformation);
        }
        public void Update(busoppinformation busoppinformation)
        {
            _busoppinformationService.Update(busoppinformation);
        }
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
