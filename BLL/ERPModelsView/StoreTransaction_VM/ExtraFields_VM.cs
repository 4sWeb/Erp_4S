using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class ExtraFields_VM
    {
        public decimal? TYPE_ID { get; set; }
        public string TYPE_NAME { get; set; }
        public string NAME { get; set; }
        public string CODE { get; set; }
        public string EXTRA_FIELD_NAME { get; set; }
        public string EXTRA_FIELD_E_NAME { get; set; }
        public string EXTRA_FIELD_VALUE { get; set; }
    }
}
