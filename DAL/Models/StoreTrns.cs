using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrns
    {
        public StoreTrns()
        {
            //StoreDepSpecs = new HashSet<StoreDepSpecs>();
            //StoreDepSpecsDetails = new HashSet<StoreDepSpecsDetails>();
            //StoreTrnsAccept = new HashSet<StoreTrnsAccept>();
            //StoreTrnsM = new HashSet<StoreTrnsM>();
            //Storedsttypes = new HashSet<Storedsttypes>();
            //Storetrnsextras = new HashSet<Storetrnsextras>();
        }
        [Key]
        public int TrnsCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte TrnsType { get; set; }
        public byte TrnsNature { get; set; }
        public short? SalesRep { get; set; }
        public short? PriceEffect { get; set; }
        public short? PayEffect { get; set; }
        public short? QtyEffect { get; set; }
        public byte? ItemPrice { get; set; }
        public short? TrnsDisc { get; set; }
        public decimal? TrnsDiscRate { get; set; }
        public short? ItemDisc { get; set; }
        public short? Stax { get; set; }
        public decimal? StaxRate { get; set; }
        public short? Ctax { get; set; }
        public decimal? CtaxRate { get; set; }
        public short? ItemStax { get; set; }
        public int? StoreItemfromsSpecsId { get; set; }
        public int? FromStoreAllcodesId { get; set; }
        public int? ToStoreAllcodesId { get; set; }
        public byte? Item2ndprice { get; set; }
        public short? ShowPrice { get; set; }
        public short? Show2ndprice { get; set; }
        public short? Item2ndpriceEffect { get; set; }
        public decimal? ItemPricelistId { get; set; }
        public short? GetPricelist { get; set; }
        public short? Shippingspecs { get; set; }
        public short? Shippingeffectonholder { get; set; }
        public short? TrnsnoCreation { get; set; }
        public short? TrnsnoRepeat { get; set; }
        public short? TrnsnoEdit { get; set; }
        public short? DocnumCreation { get; set; }
        public short? DocnumRepeat { get; set; }
        public short? DocnumEdit { get; set; }
        public short? CustmorDisc { get; set; }
        public short? Item2nddisc { get; set; }
        public short? Getdisclist { get; set; }
        public decimal? ItemDisclistId { get; set; }
        public decimal? Hascashpayment { get; set; }
        public int? Cashid { get; set; }
        public int? Financetranscode { get; set; }
        public decimal? Multycurrency { get; set; }
        public short? Needaccept { get; set; }
        public decimal? Acceptcount { get; set; }
        public short? Hasexpenses { get; set; }
        public short? ExpensesEffect { get; set; }
        public short? CtaxDisc { get; set; }
        public decimal? CtaxDiscRate { get; set; }
        public decimal? Financedistid { get; set; }
        public short? MainCostCenter { get; set; }
        public short? MainAccount { get; set; }
        public short? DetailCostCenter { get; set; }
        public short? DetailAccount { get; set; }
        public short? DepositFlag { get; set; }
        public short? AllowanceDateType { get; set; }
        public short? HasStartDate { get; set; }
        public short? HasEndDate { get; set; }
        public short? ShowBal { get; set; }
        public short? Costcentereffect { get; set; }
        public short? CustmorCtax { get; set; }
        public short? TransferCostType { get; set; }
        public decimal? Dsttype { get; set; }
        public short? Mustdsttype { get; set; }
        public short? Dstindetails { get; set; }
        public int? Dstdetailstype { get; set; }
        public short? Transrepeatonperiod { get; set; }
        public short? Docrepeatonperiod { get; set; }
        public short? Usebarcode { get; set; }
        public short? Showtax41 { get; set; }
        public short? Showlc { get; set; }
        public short? Showdependdoc { get; set; }
        public short? Showcargo { get; set; }
        public short? Showtermsofpayment { get; set; }
        public short? Showrequireddocument { get; set; }
        public short? Showsupplyorderstatus { get; set; }
        public short? Showexpchoose { get; set; }
        public short? Reservation { get; set; }
        public short? Hasproductiondata { get; set; }
        public decimal? Noduplicateserial { get; set; }
        public short? Fromrequired { get; set; }
        public short? Torequired { get; set; }
        public short? Stage { get; set; }
        public short? Createitems { get; set; }
        public short? Approvedvendor { get; set; }
        public short? Committeeexist { get; set; }
        public short? Mobiletrans { get; set; }
        public short? Weekno { get; set; }
        public short? Fromtodate { get; set; }
        public short? Itemapproved { get; set; }
        public short? Begintime { get; set; }
        public short? Endtime { get; set; }
        public short? Safeperiod { get; set; }
        public short? Paymenttype { get; set; }
        public short? Deliveryplace { get; set; }
        public short? Inttradespec { get; set; }
        public short? Receivedate { get; set; }
        public short? Choicereason { get; set; }
        public short? Paymentspec { get; set; }
        public decimal? Committee { get; set; }
        public short? Irrigationneed { get; set; }
        public short? Pool { get; set; }
        public short? Allowqtyedit { get; set; }
        public short? Cargoexpected { get; set; }
        public short? Cargoactually { get; set; }
        public short? Cargopaper { get; set; }
        public short? Portarrival { get; set; }
        public short? Detentionrev { get; set; }
        public short? Releasetype { get; set; }
        public short? Licenseno { get; set; }
        public short? Licensedate { get; set; }
        public short? Agriitems { get; set; }
        public short? Typeid { get; set; }
        public short? Agridataid { get; set; }
        public short? Managername { get; set; }
        public short? Employeeno { get; set; }
        public short? Irrigatemachine { get; set; }
        public short? Watervolume { get; set; }
        public short? Actualspace { get; set; }
        public short? Waterpressure { get; set; }
        public short? Purpose { get; set; }
        public short? Injureid { get; set; }
        public short? Phi { get; set; }
        public short? Workingtime { get; set; }
        public short? Restrictionperiod { get; set; }
        public short? Requiredprocedure { get; set; }
        public short? Ageid { get; set; }
        public short? Agriid { get; set; }
        public short? Processid { get; set; }
        public short? Fertunit { get; set; }
        public short? Agriqty { get; set; }
        public short? Agridata { get; set; }
        public short? Fromtime { get; set; }
        public short? Totime { get; set; }
        public short? Soilcond { get; set; }
        public short? Weathercond { get; set; }
        public short? Enginepressure { get; set; }
        public short? Irrigationempshow { get; set; }
        public short? Agrinorepeat { get; set; }
        public short? Taxdiscprnt { get; set; }
        public short? ExpensesCurr { get; set; }
        public short? ExpensesRate { get; set; }
        public short? ExpensesDist { get; set; }
        public short? Showexptype { get; set; }
        public short? Showprodstage { get; set; }
        public string Printcostprice { get; set; }
        public short? Showpopprice { get; set; }
        public short? Showfarm { get; set; }
        public short? Showagricontainer { get; set; }
        public short? Shipco { get; set; }
        public short? Shiptrns { get; set; }
        public short? Clearanceco { get; set; }
        public short? Shipport { get; set; }
        public short? Arrivalport { get; set; }
        public short? Shipboat { get; set; }
        public short? Shippolino { get; set; }
        public short? Shipweekno { get; set; }
        public short? Shiplotno { get; set; }
        public short? Itemclone { get; set; }
        public short? Getdisclist2 { get; set; }
        public short? Showeditbtn { get; set; }
        public short? Itempriceavg { get; set; }
        public decimal? Freeitem { get; set; }
        public int? Pricedecpoints { get; set; }
        public short? Mustaccount { get; set; }
        public short? Mustdimension { get; set; }
        public short? Execperco { get; set; }
        public short? Prevperc { get; set; }
        public string Customdocno { get; set; }
        public string Customdocnoar { get; set; }
        public decimal? Customdocnoshow { get; set; }
        public short? Patchno { get; set; }
        public short? Lotasdocno { get; set; }

        [ForeignKey("Cashid")]
        public virtual StoreAllcodes Cash { get; set; }
        [ForeignKey("Dstdetailstype")]
        public virtual MainTypes DstdetailstypeNavigation { get; set; }
        [ForeignKey("Financetranscode")]
        public virtual Financespec FinancetranscodeNavigation { get; set; }
        [ForeignKey("FromStoreAllcodesId")]
        public virtual StoreAllcodes FromStoreAllcodes { get; set; }
        [ForeignKey("StoreItemfromsSpecsId")]
        public virtual StoreItemformsSpecs StoreItemfromsSpecs { get; set; }
        [ForeignKey("ToStoreAllcodesId")]
        public virtual StoreAllcodes ToStoreAllcodes { get; set; }
        //public virtual ICollection<StoreDepSpecs> StoreDepSpecs { get; set; }
        //public virtual ICollection<StoreDepSpecsDetails> StoreDepSpecsDetails { get; set; }
        //public virtual ICollection<StoreTrnsAccept> StoreTrnsAccept { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
        //public virtual ICollection<Storedsttypes> Storedsttypes { get; set; }
        //public virtual ICollection<Storetrnsextras> Storetrnsextras { get; set; }
    }
}
