using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
    public class Transaction_VM
    {
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public DateTime TrnsDate { get; set; }
        public decimal? Period { get; set; }
        public decimal? FromStoreAllcodesId { get; set; }
        public decimal? ToStoreAllcodesId { get; set; }
        public decimal StoreTrnsMId { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? Storedocnum { get; set; }
    }
}
