using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsOTemp
    {
        public StoreTrnsOTemp()
        {
            StoreTrnsDepDetailsTemps = new HashSet<StoreTrnsDepDetailsTemp>();
            StoreTrnsExpTemps = new HashSet<StoreTrnsExpTemp>();
            StoreTrnsoDimendetailsTemps = new HashSet<StoreTrnsoDimendetailsTemp>();
        }

        public decimal StoreTrnsOId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? DiscVal { get; set; }
        public decimal? StaxVal { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? TrnsPriceForcost { get; set; }
        public decimal? StoreTrnsMId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? ItemKind { get; set; }
        public decimal? Trnsods { get; set; }
        public decimal? Unit2ndprice { get; set; }
        public decimal? Item2nddiscRate { get; set; }
        public decimal? Item2nddiscVal { get; set; }
        public decimal? Totalo { get; set; }
        public decimal? DetailCostcenterid { get; set; }
        public decimal? DetailAccountid { get; set; }
        public decimal? Dstid { get; set; }
        public decimal? Commited { get; set; }
        public string Rowstate { get; set; }
        public string Growerno { get; set; }
        public string Containerno { get; set; }
        public string Numbervalue { get; set; }
        public string Stringvalue { get; set; }
        public decimal? Productionstageid { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public decimal? ProdformlaId { get; set; }
        public bool? Itemapproved { get; set; }
        public string Notes { get; set; }
        public decimal? Weekno { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime? Begintime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? Safeperiod { get; set; }
        public decimal? Distexpcost { get; set; }

        public virtual StoreAllcode Dst { get; set; }
        public virtual StoreItem Item { get; set; }
        public virtual Productstage Productionstage { get; set; }
        public virtual StoreTrnsMTemp StoreTrnsM { get; set; }
        public virtual StoreUnit Unit { get; set; }
        public virtual ICollection<StoreTrnsDepDetailsTemp> StoreTrnsDepDetailsTemps { get; set; }
        public virtual ICollection<StoreTrnsExpTemp> StoreTrnsExpTemps { get; set; }
        public virtual ICollection<StoreTrnsoDimendetailsTemp> StoreTrnsoDimendetailsTemps { get; set; }
    }
}
