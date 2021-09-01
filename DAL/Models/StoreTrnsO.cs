using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsO
    {
        public StoreTrnsO()
        {
            EvaluaPricePromationDetails = new HashSet<EvaluaPricePromationDetail>();
            Reservationitems = new HashSet<Reservationitem>();
            StoreTrnsDepDetails = new HashSet<StoreTrnsDepDetail>();
            StoreTrnsExps = new HashSet<StoreTrnsExp>();
            StoreTrnsProducationformlas = new HashSet<StoreTrnsProducationformla>();
            StoreTrnsoDimensionsdetails = new HashSet<StoreTrnsoDimensionsdetail>();
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
        public string Itemnotes { get; set; }
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
        public decimal? Poolid { get; set; }
        public bool? Detentionrev { get; set; }
        public string Releasetype { get; set; }
        public string Licenseno { get; set; }
        public DateTime? Licensedatefrom { get; set; }
        public DateTime? Licensedateto { get; set; }
        public decimal? Agriageid { get; set; }
        public decimal? Processid { get; set; }
        public string Watervolume { get; set; }
        public string Actualspace { get; set; }
        public string Waterpressure { get; set; }
        public string Purpose { get; set; }
        public decimal? Injureid { get; set; }
        public string Phi { get; set; }
        public decimal? Workingtime { get; set; }
        public string Restrictionperiod { get; set; }
        public string Requiredprocedure { get; set; }
        public string Injpercentage { get; set; }
        public decimal? Fertunitid { get; set; }
        public decimal? Agriqty { get; set; }
        public DateTime? Fromtime { get; set; }
        public DateTime? Totime { get; set; }
        public string Enginepressure { get; set; }
        public decimal? Itemnetperc { get; set; }
        public decimal? Itemtotalperc { get; set; }
        public decimal? Distexpcost { get; set; }
        public decimal? Agrifarmid { get; set; }
        public string Agricontainerno { get; set; }
        public decimal? Freeitem { get; set; }
        public decimal? UnitOldprice { get; set; }
        public decimal? Execperc { get; set; }

        public virtual Agrifarm Agrifarm { get; set; }
        public virtual StoreAllcode Dst { get; set; }
        public virtual StoreAllsubcode Fertunit { get; set; }
        public virtual StoreAllcode Injure { get; set; }
        public virtual StoreItem Item { get; set; }
        public virtual Agriprocess Process { get; set; }
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        public virtual StoreUnit Unit { get; set; }
        public virtual Agriage WorkingtimeNavigation { get; set; }
        public virtual ICollection<EvaluaPricePromationDetail> EvaluaPricePromationDetails { get; set; }
        public virtual ICollection<Reservationitem> Reservationitems { get; set; }
        public virtual ICollection<StoreTrnsDepDetail> StoreTrnsDepDetails { get; set; }
        public virtual ICollection<StoreTrnsExp> StoreTrnsExps { get; set; }
        public virtual ICollection<StoreTrnsProducationformla> StoreTrnsProducationformlas { get; set; }
        public virtual ICollection<StoreTrnsoDimensionsdetail> StoreTrnsoDimensionsdetails { get; set; }


        //public decimal ITEMAPPROVED  { get; set; }
        //public decimal ITEMPL { get; set; }
        //public decimal ITEMPLCHOOSEFLAG { get; set; }
       
        //public decimal ItemFormId { get; set; }

        //public decimal ORIGNALQTY { get; set; }
        //public decimal OldPrice { get; set; }
        //public decimal PLDEALPRICE  { get; set; }
        //public decimal PLMAINPRICE { get; set; }
        //public string RELEASETYPE { get; set; }
        //public decimal RowIndex { get; set; }
    }
}
