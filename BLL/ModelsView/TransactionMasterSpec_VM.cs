using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class TransactionMasterSpec_VM
    {
       
        public object Branches { get; set; }
        public object From_Type { get; set; }  // ( Altaraf From )
        public object To_Type { get; set; }    // ( Altaraf TO )
        public object FromTypeDetails { get; set; }  // ( Altaraf From )
        public object ToTypeDetails { get; set; }    // ( Altaraf TO )
    }
}
