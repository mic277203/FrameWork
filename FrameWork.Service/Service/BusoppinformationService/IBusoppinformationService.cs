using FrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Service
{
    public interface IBusoppinformationService
    {
        IEnumerable<busoppinformation> GetBusoppinformations();
        void Insert(busoppinformation busoppinformation);
        void Update(busoppinformation busoppinformation);

        void SaveChanges();
    }
}
