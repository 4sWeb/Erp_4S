using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
    public class StoreTransDep_VM
    {
        public decimal? Ptransrowid { get; set; }
        public decimal Ctrnsrowid { get; set; }
        public decimal? Commited { get; set; }
        public decimal? Depslot { get; set; }
        public decimal? Depdetailsid { get; set; }
        public decimal StoreTrnsDepId { get; set; }
        public decimal? Groupid { get; set; }
        public decimal BranchId { get; set; }
        public decimal FromStoreAllcodesId { get; set; }
        public decimal ToStoreAllcodesId { get; set; }
        public string Rem { get; set; }
        public DateTime TrnsDate { get; set; }
        public decimal TrnsCode { get; set; }

        public string BranchName { get; set; }
        public string From_TypeName { get; set; }
        public string TO_TypeName { get; set; }
        public string From_StoreAllcodesName { get; set; }
        public string To_StoreAllcodesName { get; set; }
    }
}
