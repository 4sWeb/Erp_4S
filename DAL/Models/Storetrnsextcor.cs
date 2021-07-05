﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsextcor
    {
        public decimal Trnscode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte Trnstype { get; set; }
        public byte Trnsnature { get; set; }
        public bool? Salesrep { get; set; }
        public bool? Priceeffect { get; set; }
        public bool? Payeffect { get; set; }
        public bool? Qtyeffect { get; set; }
        public byte? Itemprice { get; set; }
        public bool? Trnsdisc { get; set; }
        public decimal? Trnsdiscrate { get; set; }
        public bool? Itemdisc { get; set; }
        public bool? Stax { get; set; }
        public decimal? Staxrate { get; set; }
        public bool? Ctax { get; set; }
        public decimal? Ctaxrate { get; set; }
        public bool? Itemstax { get; set; }
        public decimal? Storeitemfromsspecsid { get; set; }
        public decimal? Fromstoreallcodesid { get; set; }
        public decimal? Tostoreallcodesid { get; set; }
        public byte? Item2ndprice { get; set; }
        public bool? Showprice { get; set; }
        public bool? Show2ndprice { get; set; }
        public bool? Item2ndpriceeffect { get; set; }
        public decimal? Itempricelistid { get; set; }
        public bool? Getpricelist { get; set; }
        public bool? Shippingspecs { get; set; }
        public bool? Shippingeffectonholder { get; set; }
        public bool? Trnsnocreation { get; set; }
        public bool? Trnsnorepeat { get; set; }
        public bool? Trnsnoedit { get; set; }
        public bool? Docnumcreation { get; set; }
        public bool? Docnumrepeat { get; set; }
        public bool? Docnumedit { get; set; }
        public bool? Custmordisc { get; set; }
        public bool? Item2nddisc { get; set; }
        public bool? Getdisclist { get; set; }
        public decimal? Itemdisclistid { get; set; }
        public decimal? Hascashpayment { get; set; }
        public decimal? Cashid { get; set; }
        public decimal? Financetranscode { get; set; }
        public decimal? Multycurrency { get; set; }
        public bool? Needaccept { get; set; }
        public decimal? Acceptcount { get; set; }
        public bool? Hasexpenses { get; set; }
        public bool? Expenseseffect { get; set; }
        public bool? Ctaxdisc { get; set; }
        public decimal? Ctaxdiscrate { get; set; }
        public decimal? Financedistid { get; set; }
        public bool? Maincostcenter { get; set; }
        public bool? Mainaccount { get; set; }
        public bool? Detailcostcenter { get; set; }
        public bool? Detailaccount { get; set; }
        public bool? Depositflag { get; set; }
        public bool? AllowanceDateType { get; set; }
        public bool? Hasstartdate { get; set; }
        public bool? Hasenddate { get; set; }
        public bool? Showbal { get; set; }
        public bool? Costcentereffect { get; set; }
        public bool? Custmorctax { get; set; }
        public bool? Transfercosttype { get; set; }
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
        public bool? Agridata { get; set; }
        public bool? Fertunit { get; set; }
        public bool? Agriqty { get; set; }
        public bool? Fromtime { get; set; }
        public bool? Totime { get; set; }
        public bool? Soilcond { get; set; }
        public bool? Weathercond { get; set; }
        public bool? Enginepressure { get; set; }
        public bool? Irrigationempshow { get; set; }
        public bool? Agrinorepeat { get; set; }
        public bool? Taxdiscprnt { get; set; }
        public bool? Expensescurr { get; set; }
        public bool? Expensesrate { get; set; }
        public bool? Expensesdist { get; set; }
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
        public decimal? Hasdep { get; set; }
    }
}
