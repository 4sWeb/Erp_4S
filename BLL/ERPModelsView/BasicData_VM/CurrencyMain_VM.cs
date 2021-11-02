using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView.BasicData_VM
{
   public class CurrencyMain_VM
    {
        public CurrencyMaster_VM CurrencyMaster_VM { get; set; }
        public List<CurrencyRates_VM> CurrencyRates_VM { get; set; }
    }
}
