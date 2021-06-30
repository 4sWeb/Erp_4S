using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Financespec
    {
        public Financespec()
        {
           // StoreTrns = new HashSet<StoreTrns>();
        }

        [Key]
        public int Trnscode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public int? Defpurpose { get; set; }
        public string Iscash { get; set; }
        public int? Istransfer { get; set; }
        public string Usefdistcode { get; set; }
        public int? Fdistid { get; set; }
        public string Usetdistcode { get; set; }
        public int? Tdistid { get; set; }
        public string Userepcode { get; set; }
        public int? Repid { get; set; }
        public string Useanalysiscode { get; set; }
        public int? Analysisid { get; set; }
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
        public int? CD { get; set; }
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

        [ForeignKey("Analysisid")]
        public virtual StoreAllcodes Analysis { get; set; }
        [ForeignKey("CD")]
        public virtual Financetype CDNavigation { get; set; }
        [ForeignKey("Defpurpose")]
        public virtual Financepuposes DefpurposeNavigation { get; set; }
        [ForeignKey("Fdistid")]
        public virtual StoreAllcodes Fdist { get; set; }
        [ForeignKey("Istransfer")]
        public virtual Istransfer IstransferNavigation { get; set; }
        [ForeignKey("Repid")]
        public virtual StoreAllcodes Rep { get; set; }
        [ForeignKey("Tdistid")]
        public virtual StoreAllcodes Tdist { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrns { get; set; }
    }
}
