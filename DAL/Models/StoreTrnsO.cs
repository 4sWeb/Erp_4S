using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsO
    {
        public StoreTrnsO()
        {
            //StoreTrnsDepDetails = new HashSet<StoreTrnsDepDetails>();
            //StoreTrnsProducationformla = new HashSet<StoreTrnsProducationformla>();
            //StoreTrnsoDimensionsdetails = new HashSet<StoreTrnsoDimensionsdetails>();
        }

        [Key]
        public int StoreTrnsOId { get; set; }
        public decimal? Qty { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? DiscVal { get; set; }
        public decimal? StaxVal { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? TrnsPriceForcost { get; set; }
        public int? StoreTrnsMId { get; set; }
        public int? ItemId { get; set; }
        public decimal? ItemKind { get; set; }
        public decimal? Trnsods { get; set; }
        public decimal? Unit2ndprice { get; set; }
        public decimal? Item2nddiscRate { get; set; }
        public decimal? Item2nddiscVal { get; set; }
        public decimal? Totalo { get; set; }
        public decimal? DetailCostcenterid { get; set; }
        public decimal? DetailAccountid { get; set; }
        public int? Dstid { get; set; }
        public decimal? Commited { get; set; }
        public string Itemnotes { get; set; }
        public string Growerno { get; set; }
        public string Containerno { get; set; }
        public string Numbervalue { get; set; }
        public string Stringvalue { get; set; }
        public decimal? Productionstageid { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public decimal? ProdformlaId { get; set; }
        public short? Itemapproved { get; set; }
        public string Notes { get; set; }
        public decimal? Weekno { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime? Begintime { get; set; }
        public DateTime? Endtime { get; set; }
        public decimal? Safeperiod { get; set; }
        public decimal? Poolid { get; set; }
        public short? Detentionrev { get; set; }
        public string Releasetype { get; set; }
        public string Licenseno { get; set; }
        public DateTime? Licensedatefrom { get; set; }
        public DateTime? Licensedateto { get; set; }
        public int? Agriageid { get; set; }
        public int? Processid { get; set; }
        public string Watervolume { get; set; }
        public string Actualspace { get; set; }
        public string Waterpressure { get; set; }
        public string Purpose { get; set; }
        public int? Injureid { get; set; }
        public string Phi { get; set; }
        public int? Workingtime { get; set; }
        public string Restrictionperiod { get; set; }
        public string Requiredprocedure { get; set; }
        public string Injpercentage { get; set; }
        public int? Fertunitid { get; set; }
        public decimal? Agriqty { get; set; }
        public DateTime? Fromtime { get; set; }
        public DateTime? Totime { get; set; }
        public string Enginepressure { get; set; }
        public decimal? Itemnetperc { get; set; }
        public decimal? Itemtotalperc { get; set; }
        public decimal? Distexpcost { get; set; }
        public int? Agrifarmid { get; set; }
        public string Agricontainerno { get; set; }
        public decimal? Freeitem { get; set; }
        public decimal? UnitOldprice { get; set; }
        public decimal? Execperc { get; set; }

        [ForeignKey("Agriageid")]
        public virtual Agriprocess Agriage { get; set; }
        [ForeignKey("Agrifarmid")]
        public virtual Agrifarm Agrifarm { get; set; }
        [ForeignKey("Dstid")]
        public virtual StoreAllcodes Dst { get; set; }
        [ForeignKey("Fertunitid")]
        public virtual StoreAllsubcodes Fertunit { get; set; }
        [ForeignKey("Injureid")]
        public virtual StoreAllcodes Injure { get; set; }
        [ForeignKey("ItemId")]
        public virtual StoreItems Item { get; set; }
        [ForeignKey("Processid")]
        public virtual Agriprocess Process { get; set; }
        [ForeignKey("StoreTrnsMId")]
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        [ForeignKey("UnitId")]
        public virtual StoreUnits Unit { get; set; }
        [ForeignKey("Workingtime")]
        public virtual Agriage WorkingtimeNavigation { get; set; }
        //public virtual ICollection<StoreTrnsDepDetails> StoreTrnsDepDetails { get; set; }
        //public virtual ICollection<StoreTrnsProducationformla> StoreTrnsProducationformla { get; set; }
        //public virtual ICollection<StoreTrnsoDimensionsdetails> StoreTrnsoDimensionsdetails { get; set; }
    }
}
