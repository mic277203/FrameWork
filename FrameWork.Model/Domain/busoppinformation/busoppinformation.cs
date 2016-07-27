using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Model
{
    public class busoppinformation
    {
        public string id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int? viewtimes { get; set; }
        public string source { get; set; }
        public DateTime? createdate { get; set; }
        public DateTime? logdate { get; set; }
    }
}
