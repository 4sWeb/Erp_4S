using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class StoreTransDetails_VM
    {
        public decimal storeTrnsOId { get; set; }
        public int groupF_Id { get; set; }
        public decimal? qty { get; set; }
        public decimal? unitId { get; set; }
        public string  unit_Name { get; set; }
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






   


        //public decimal? TrnsPriceForcost { get; set; }
        //public decimal? Trnsods { get; set; }
        //public decimal? Unit2ndprice { get; set; }
        //public decimal? Item2nddiscRate { get; set; }
        //public decimal? DetailCostcenterid { get; set; }
        //public decimal? DetailAccountid { get; set; }
        //public decimal? Dstid { get; set; }
        //public decimal? Commited { get; set; }
        //public string Itemnotes { get; set; }
        //public string Growerno { get; set; }
        //public string Containerno { get; set; }
        //public string Numbervalue { get; set; }
        //public string Stringvalue { get; set; }
        //public decimal? Productionstageid { get; set; }


        //public DateTime? Fromdate { get; set; }
        //public DateTime? Begintime { get; set; }
        //public DateTime? Endtime { get; set; }
        //public decimal? Safeperiod { get; set; }
        //public decimal? Poolid { get; set; }
        //public bool? Detentionrev { get; set; }
        //public string Releasetype { get; set; }
        //public string Licenseno { get; set; }
        //public DateTime? Licensedatefrom { get; set; }
        //public DateTime? Licensedateto { get; set; }
        //public decimal? Agriageid { get; set; }
        //public decimal? Processid { get; set; }
        //public string Watervolume { get; set; }
        //public string Actualspace { get; set; }
        //public string Waterpressure { get; set; }
        //public string Purpose { get; set; }
        //public decimal? Injureid { get; set; }
        //public string Phi { get; set; }
        //public decimal? Workingtime { get; set; }
        //public string Restrictionperiod { get; set; }
        //public string Requiredprocedure { get; set; }
        //public string Injpercentage { get; set; }
        //public decimal? Fertunitid { get; set; }
        //public decimal? Itemnetperc { get; set; }
        //public decimal? Itemtotalperc { get; set; }
        //public decimal? Distexpcost { get; set; }
        //public decimal? Agrifarmid { get; set; }
        //public string Agricontainerno { get; set; }
        //public decimal? Freeitem { get; set; }
        //public decimal? Execperc { get; set; }



    }
}
