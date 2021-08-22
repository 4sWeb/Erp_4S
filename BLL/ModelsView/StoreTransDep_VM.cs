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
        public decimal? Groupid { get; set; }
        public decimal BranchId { get; set; }
        public decimal FromStoreAllcodesId { get; set; }
        public decimal ToStoreAllcodesId { get; set; }
        public string Rem { get; set; }
        public DateTime TrnsDate { get; set; }
    }
}
