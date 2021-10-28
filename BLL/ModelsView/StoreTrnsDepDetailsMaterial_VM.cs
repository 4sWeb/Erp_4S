using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
    public class StoreTrnsDepDetailsMaterial_VM
    {
     
        public decimal storeTrnsOId { get; set; }
        public int groupF_Id { get; set; }
        public string groupF_Name { get; set; }
        public decimal? qty { get; set; }
        public decimal? unitId { get; set; }
        public string unit_Name { get; set; }
        public decimal? unitPrice { get; set; }
        public decimal totalo { get; set; }
        public decimal? weekno { get; set; }
        public decimal storeTrnsMId { get; set; }
        public DateTime? todate { get; set; }
        public decimal? staxVal { get; set; }
        public decimal? unitOldprice { get; set; }
        public decimal? itemId { get; set; }
        public decimal? itemKind { get; set; }
        public decimal? itemCost { get; set; }
        public string notes { get; set; }
        public bool? itemapproved { get; set; }
        public string item_Name { get; internal set; }
        public decimal? discVal { get; set; }
        public decimal? agriqty { get; set; }
        public decimal? item2nddiscVal { get; set; }
        public decimal? storetrnsProformlaId { get; set; }
        public ItemDetails_VM itemDetails_VM { get; set; }

        //last added to replace TransactionDetails_VM
        public decimal? price { get; set; }
        public decimal? disc_Rate { get; set; }
        public decimal? disc_Value { get; set; }
        public decimal? tax_Rate { get; set; }
        public decimal? tax_Value { get; set; }
        public decimal? profit_Tax_Rate { get; set; }
        public decimal? profit_Tax_Value { get; set; }
        public decimal net_Value { get; set; }
        public decimal store_Trns_M_ID { get; set; }
        
    }
}
