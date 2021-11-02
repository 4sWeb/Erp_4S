using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class TransactionMasterSpec_VM
    {
        public TransactionMasterSpec_VM()
        {
            Branches = new List<Branches_VM>();
        }
       
        public List<Branches_VM> Branches { get; set; }
        public object From_Type { get; set; }  // ( Altaraf From )
        public object To_Type { get; set; }    // ( Altaraf TO )
        public object FromTypeDetails { get; set; }  // ( Altaraf From )
        public object ToTypeDetails { get; set; }    // ( Altaraf TO )
    }
}
