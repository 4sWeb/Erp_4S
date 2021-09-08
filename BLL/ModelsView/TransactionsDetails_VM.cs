using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class TransactionsDetails_VM
    {
        public decimal? Item_ID { get; set; }
        public string Item_Name { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Value { get; set; }
        public decimal? Unit_ID { get; set; }
        public string Unit_Name { get; set; }
        public decimal? Tax_Rate { get; set; }
        public decimal? Tax_Value { get; set; }
        public decimal? Disc_Rate { get; set; }
        public decimal? Disc_Value { get; set; }
        public decimal? Profit_Tax_Rate { get; set; }
        public decimal? Profit_Tax_Value { get; set; }
        public decimal? Net_Value { get; set; }
        public decimal? Store_Trns_M_ID { get; set; }
        public string Note { get; set; }
        public decimal? StoreTrnsOID { get; set; }
    }
}
