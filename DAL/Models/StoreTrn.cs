using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrn
    {
        public StoreTrn()
        {
            Financeinvspecs = new HashSet<Financeinvspec>();
            ItemchangemStoreTrns = new HashSet<ItemchangemStoreTrn>();
            StoreDepSpecs = new HashSet<StoreDepSpec>();
            StoreDepSpecsDetails = new HashSet<StoreDepSpecsDetail>();
            StoreTrnsAccepts = new HashSet<StoreTrnsAccept>();
            StoreTrnsMTemps = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMs = new HashSet<StoreTrnsM>();
            StoreTrnsfromtrnTrnsCodeMNavigations = new HashSet<StoreTrnsfromtrn>();
            StoreTrnsfromtrnTrnsCodeSNavigations = new HashSet<StoreTrnsfromtrn>();
            Storedsttypes = new HashSet<Storedsttype>();
            StoretrnsextexpTrnsmcodeNavigations = new HashSet<Storetrnsextexp>();
            StoretrnsextexpTrnsscodeNavigations = new HashSet<Storetrnsextexp>();
            Storetrnsextras = new HashSet<Storetrnsextra>();
            TrnsPrintSpecs = new HashSet<TrnsPrintSpec>();
        }

        public decimal TrnsCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte TrnsType { get; set; }
        public byte TrnsNature { get; set; }
        public bool? SalesRep { get; set; }
        public bool? PriceEffect { get; set; }
        public bool? PayEffect { get; set; }
        public bool? QtyEffect { get; set; }
        public byte? ItemPrice { get; set; }
        public bool? TrnsDisc { get; set; }
        public decimal? TrnsDiscRate { get; set; }
        public bool? ItemDisc { get; set; }
        public bool? Stax { get; set; }
        public decimal? StaxRate { get; set; }
        public bool? Ctax { get; set; }
        public decimal? CtaxRate { get; set; }
        public bool? ItemStax { get; set; }
        public decimal? StoreItemfromsSpecsId { get; set; }
        public decimal? FromStoreAllcodesId { get; set; }
        public decimal? ToStoreAllcodesId { get; set; }
        public byte? Item2ndprice { get; set; }
        public bool? ShowPrice { get; set; }
        public bool? Show2ndprice { get; set; }
        public bool? Item2ndpriceEffect { get; set; }
        public decimal? ItemPricelistId { get; set; }
        public bool? GetPricelist { get; set; }
        public bool? Shippingspecs { get; set; }
        public bool? Shippingeffectonholder { get; set; }
        public bool? TrnsnoCreation { get; set; }
        public bool? TrnsnoRepeat { get; set; }
        public bool? TrnsnoEdit { get; set; }
        public bool? DocnumCreation { get; set; }
        public bool? DocnumRepeat { get; set; }
        public bool? DocnumEdit { get; set; }
        public bool? CustmorDisc { get; set; }
        public bool? Item2nddisc { get; set; }
        public bool? Getdisclist { get; set; }
        public decimal? ItemDisclistId { get; set; }
        public decimal? Hascashpayment { get; set; }
        public decimal? Cashid { get; set; }
        public decimal? Financetranscode { get; set; }
        public decimal? Multycurrency { get; set; }
        public bool? Needaccept { get; set; }
        public decimal? Acceptcount { get; set; }
        public bool? Hasexpenses { get; set; }
        public bool? ExpensesEffect { get; set; }
        public bool? CtaxDisc { get; set; }
        public decimal? CtaxDiscRate { get; set; }
        public decimal? Financedistid { get; set; }
        public bool? MainCostCenter { get; set; }
        public bool? MainAccount { get; set; }
        public bool? DetailCostCenter { get; set; }
        public bool? DetailAccount { get; set; }
        public bool? DepositFlag { get; set; }
        public bool? AllowanceDateType { get; set; }
        public bool? HasStartDate { get; set; }
        public bool? HasEndDate { get; set; }
        public bool? ShowBal { get; set; }
        public bool? Costcentereffect { get; set; }
        public bool? CustmorCtax { get; set; }
        public bool? TransferCostType { get; set; }
        public decimal? Dsttype { get; set; }
        public bool? Mustdsttype { get; set; }
        public bool? Dstindetails { get; set; }
        public decimal? Dstdetailstype { get; set; }
        public bool? Transrepeatonperiod { get; set; }
        public bool? Docrepeatonperiod { get; set; }
        public bool? Usebarcode { get; set; }
        public bool? Showtax41 { get; set; }
        public bool? Showlc { get; set; }
        public bool? Showdependdoc { get; set; }
        public bool? Showcargo { get; set; }
        public bool? Showtermsofpayment { get; set; }
        public bool? Showrequireddocument { get; set; }
        public bool? Showsupplyorderstatus { get; set; }
        public bool? Showexpchoose { get; set; }
        public bool? Reservation { get; set; }
        public bool? Hasproductiondata { get; set; }
        public decimal? Noduplicateserial { get; set; }
        public bool? Fromrequired { get; set; }
        public bool? Torequired { get; set; }
        public bool? Stage { get; set; }
        public bool? Createitems { get; set; }
        public bool? Approvedvendor { get; set; }
        public bool? Committeeexist { get; set; }
        public bool? Mobiletrans { get; set; }
        public bool? Weekno { get; set; }
        public bool? Fromtodate { get; set; }
        public bool? Itemapproved { get; set; }
        public bool? Begintime { get; set; }
        public bool? Endtime { get; set; }
        public bool? Safeperiod { get; set; }
        public bool? Paymenttype { get; set; }
        public bool? Deliveryplace { get; set; }
        public bool? Inttradespec { get; set; }
        public bool? Receivedate { get; set; }
        public bool? Choicereason { get; set; }
        public bool? Paymentspec { get; set; }
        public decimal? Committee { get; set; }
        public bool? Irrigationneed { get; set; }
        public bool? Pool { get; set; }
        public bool? Allowqtyedit { get; set; }
        public bool? Cargoexpected { get; set; }
        public bool? Cargoactually { get; set; }
        public bool? Cargopaper { get; set; }
        public bool? Portarrival { get; set; }
        public bool? Detentionrev { get; set; }
        public bool? Releasetype { get; set; }
        public bool? Licenseno { get; set; }
        public bool? Licensedate { get; set; }
        public bool? Agriitems { get; set; }
        public bool? Typeid { get; set; }
        public bool? Agridataid { get; set; }
        public bool? Managername { get; set; }
        public bool? Employeeno { get; set; }
        public bool? Irrigatemachine { get; set; }
        public bool? Watervolume { get; set; }
        public bool? Actualspace { get; set; }
        public bool? Waterpressure { get; set; }
        public bool? Purpose { get; set; }
        public bool? Injureid { get; set; }
        public bool? Phi { get; set; }
        public bool? Workingtime { get; set; }
        public bool? Restrictionperiod { get; set; }
        public bool? Requiredprocedure { get; set; }
        public bool? Ageid { get; set; }
        public bool? Agriid { get; set; }
        public bool? Processid { get; set; }
        public bool? Fertunit { get; set; }
        public bool? Agriqty { get; set; }
        public bool? Agridata { get; set; }
        public bool? Fromtime { get; set; }
        public bool? Totime { get; set; }
        public bool? Soilcond { get; set; }
        public bool? Weathercond { get; set; }
        public bool? Enginepressure { get; set; }
        public bool? Irrigationempshow { get; set; }
        public bool? Agrinorepeat { get; set; }
        public bool? Taxdiscprnt { get; set; }
        public bool? ExpensesCurr { get; set; }
        public bool? ExpensesRate { get; set; }
        public bool? ExpensesDist { get; set; }
        public bool? Showexptype { get; set; }
        public bool? Showprodstage { get; set; }
        public string Printcostprice { get; set; }
        public bool? Showpopprice { get; set; }
        public bool? Showfarm { get; set; }
        public bool? Showagricontainer { get; set; }
        public bool? Shipco { get; set; }
        public bool? Shiptrns { get; set; }
        public bool? Clearanceco { get; set; }
        public bool? Shipport { get; set; }
        public bool? Arrivalport { get; set; }
        public bool? Shipboat { get; set; }
        public bool? Shippolino { get; set; }
        public bool? Shipweekno { get; set; }
        public bool? Shiplotno { get; set; }
        public bool? Itemclone { get; set; }
        public bool? Getdisclist2 { get; set; }
        public bool? Showeditbtn { get; set; }
        public bool? Itempriceavg { get; set; }
        public decimal? Freeitem { get; set; }
        public int? Pricedecpoints { get; set; }
        public bool? Mustaccount { get; set; }
        public bool? Mustdimension { get; set; }
        public bool? Execperco { get; set; }
        public bool? Prevperc { get; set; }
        public string Customdocno { get; set; }
        public string Customdocnoar { get; set; }
        public decimal? Customdocnoshow { get; set; }
        public bool? Patchno { get; set; }
        public bool? Lotasdocno { get; set; }
        public bool? Hasattachments { get; set; }

        public virtual StoreAllcode Cash { get; set; }
        public virtual MainType DstdetailstypeNavigation { get; set; }
        public virtual Financespec FinancetranscodeNavigation { get; set; }
        public virtual StoreAllcode FromStoreAllcodes { get; set; }
        public virtual StoreItemformsSpec StoreItemfromsSpecs { get; set; }
        public virtual StoreAllcode ToStoreAllcodes { get; set; }
        public virtual Costcalculation Costcalculation { get; set; }
        public virtual ShippingSpec ShippingSpec { get; set; }
        public virtual ICollection<Financeinvspec> Financeinvspecs { get; set; }
        public virtual ICollection<ItemchangemStoreTrn> ItemchangemStoreTrns { get; set; }
        public virtual ICollection<StoreDepSpec> StoreDepSpecs { get; set; }
        public virtual ICollection<StoreDepSpecsDetail> StoreDepSpecsDetails { get; set; }
        public virtual ICollection<StoreTrnsAccept> StoreTrnsAccepts { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTemps { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMs { get; set; }
        public virtual ICollection<StoreTrnsfromtrn> StoreTrnsfromtrnTrnsCodeMNavigations { get; set; }
        public virtual ICollection<StoreTrnsfromtrn> StoreTrnsfromtrnTrnsCodeSNavigations { get; set; }
        public virtual ICollection<Storedsttype> Storedsttypes { get; set; }
        public virtual ICollection<Storetrnsextexp> StoretrnsextexpTrnsmcodeNavigations { get; set; }
        public virtual ICollection<Storetrnsextexp> StoretrnsextexpTrnsscodeNavigations { get; set; }
        public virtual ICollection<Storetrnsextra> Storetrnsextras { get; set; }
        public virtual ICollection<TrnsPrintSpec> TrnsPrintSpecs { get; set; }
    }
}
