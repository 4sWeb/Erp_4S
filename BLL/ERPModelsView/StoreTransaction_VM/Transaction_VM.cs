using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
    public class Transaction_VM
    {
        public Transaction_VM()
        {

        }
        public decimal StoreTrnsMId { get; set; }
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public decimal? Storedocnum { get; set; }
        public decimal? BranchId { get; set; }
        public string branch { get; set; }
        public decimal? Period { get; set; }
        public DateTime TrnsDate { get; set; }
        public decimal? From_StoreAllcodesId { get; set; } // Altaraf From (ID)
        public string From_TypeName { get; set; }
        public string From_StoreAllcodesName { get; set; }  // Altaraf From (Name)
        public decimal? To_StoreAllcodesId { get; set; } // Altaraf TO (ID)
        public string TO_TypeName { get; set; }
        public string To_StoreAllcodesName { get; set; } // Altaraf TO (Name)

        public object From_Type { get; set; }  // ( Altaraf From )
        public object To_Type { get; set; }    // ( Altaraf TO )
        public StoreTransDep_VM StoreTransDep_VM { get; set; }
    }

}
