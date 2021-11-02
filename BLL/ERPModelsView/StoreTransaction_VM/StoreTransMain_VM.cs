using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class StoreTransMain_VM
    {
        public StoreTransMain_VM()
        {
            StoreTransDepDetails_VM = new List<StoreTransDepDetails_VM>();


        }
        public bool IsDependant { get; set; } = false;
        public StoreTransMaster_VM StoreTransMaster_VM { get; set; }
        public List<StoreTransDep_VM> StoreTransDep_VM { get; set; }
        public List< StoreTransDepDetails_VM >StoreTransDepDetails_VM { get; set; }
        public List<StoreTransDetails_VM> StoreTransDetails_VM { get; set; } 
    }
}
