using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financespec
    {
        public Financespec()
        {
            FinanceTrnsAccepts = new HashSet<FinanceTrnsAccept>();
            Financedepspecdetails = new HashSet<Financedepspecdetail>();
            Financedepspecs = new HashSet<Financedepspec>();
            Financedisttypes = new HashSet<Financedisttype>();
            Financeinvspecs = new HashSet<Financeinvspec>();
            Financems = new HashSet<Financem>();
            Financespecdetails = new HashSet<Financespecdetail>();
            Financespecprotections = new HashSet<Financespecprotection>();
            Hafzams = new HashSet<Hafzam>();
            LgDescriptionsMs = new HashSet<LgDescriptionsM>();
            LgDescriptionsOs = new HashSet<LgDescriptionsO>();
            StoreTrns = new HashSet<StoreTrn>();
        }

        public decimal Trnscode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Defpurpose { get; set; }
        public string Iscash { get; set; }
        public decimal? Istransfer { get; set; }
        public string Usefdistcode { get; set; }
        public decimal? Fdistid { get; set; }
        public string Usetdistcode { get; set; }
        public decimal? Tdistid { get; set; }
        public string Userepcode { get; set; }
        public decimal? Repid { get; set; }
        public string Useanalysiscode { get; set; }
        public decimal? Analysisid { get; set; }
        public string Usecommtax { get; set; }
        public decimal? Commtaxrate { get; set; }
        public string Usecommdtax { get; set; }
        public decimal? Commtaxdrate { get; set; }
        public string Usesalestax { get; set; }
        public decimal? Salestaxrate { get; set; }
        public string Useothertax { get; set; }
        public decimal? Othertaxrate { get; set; }
        public string Usepenaltytax { get; set; }
        public decimal? Penaltyrate { get; set; }
        public string Useremark2 { get; set; }
        public string Useconfirmed { get; set; }
        public string Usenotes { get; set; }
        public string Invoiceditribution { get; set; }
        public decimal? Inventoryspecid { get; set; }
        public string Gl { get; set; }
        public string Mustchoosefdist { get; set; }
        public string Mustchoosetdist { get; set; }
        public decimal? CD { get; set; }
        public decimal? Usefastinsertchecks { get; set; }
        public string Saleformdistribution { get; set; }
        public decimal? Printafterconfirme { get; set; }
        public decimal? Updatebyconfirmer { get; set; }
        public string ServicesRequests { get; set; }
        public bool? Showtaxdatadetails { get; set; }
        public decimal? Taxdiscsrc { get; set; }
        public decimal? Salesearch { get; set; }
        public decimal? Showpay { get; set; }
        public decimal? Showdist { get; set; }
        public decimal? Showdistcancel { get; set; }
        public string Unitcheckdist { get; set; }
        public string Attrname { get; set; }
        public string Attrnameen { get; set; }
        public decimal? Casheffect { get; set; }
        public decimal? Ismobile { get; set; }
        public bool? Currencydiff { get; set; }
        public bool? Showdeliverydata { get; set; }
        public string Isodata { get; set; }

        public virtual StoreAllcode Analysis { get; set; }
        public virtual Financetype CDNavigation { get; set; }
        public virtual Financepupose DefpurposeNavigation { get; set; }
        public virtual StoreAllcode Fdist { get; set; }
        public virtual Istransfer IstransferNavigation { get; set; }
        public virtual StoreAllcode Rep { get; set; }
        public virtual StoreAllcode Tdist { get; set; }
        public virtual ICollection<FinanceTrnsAccept> FinanceTrnsAccepts { get; set; }
        public virtual ICollection<Financedepspecdetail> Financedepspecdetails { get; set; }
        public virtual ICollection<Financedepspec> Financedepspecs { get; set; }
        public virtual ICollection<Financedisttype> Financedisttypes { get; set; }
        public virtual ICollection<Financeinvspec> Financeinvspecs { get; set; }
        public virtual ICollection<Financem> Financems { get; set; }
        public virtual ICollection<Financespecdetail> Financespecdetails { get; set; }
        public virtual ICollection<Financespecprotection> Financespecprotections { get; set; }
        public virtual ICollection<Hafzam> Hafzams { get; set; }
        public virtual ICollection<LgDescriptionsM> LgDescriptionsMs { get; set; }
        public virtual ICollection<LgDescriptionsO> LgDescriptionsOs { get; set; }
        public virtual ICollection<StoreTrn> StoreTrns { get; set; }
    }
}
