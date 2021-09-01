using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class StoreTransDepDetails_VM
    {
        public decimal Depdetailsid { get; set; }
        public decimal? Ctrnsorowid { get; set; }
        public decimal? Ptrnsorowid { get; set; }
        public decimal Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Unit_Name { get; set; }
        public string Note { get; set; }
        public decimal Unitprice { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Commited { get; set; }
        public decimal? ProwId { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Unitid { get; set; }
    }
}
