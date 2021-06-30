using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreAllcodes
    {
        public StoreAllcodes()
        {
            //Agriage = new HashSet<Agriage>();
            //Agridata = new HashSet<Agridata>();
            //Agriprocess = new HashSet<Agriprocess>();
            //Conditionsbooklet = new HashSet<Conditionsbooklet>();
            //////FinancespecAnalysis = new HashSet<Financespec>();
            //////FinancespecFdist = new HashSet<Financespec>();
            //////FinancespecRep = new HashSet<Financespec>();
            //////FinancespecTdist = new HashSet<Financespec>();
            //StoreAllcodesBegin = new HashSet<StoreAllcodesBegin>();
            //StoreSubCodeSpec = new HashSet<StoreSubCodeSpec>();
            //StoreTrnsCash = new HashSet<StoreTrns>();
            //StoreTrnsFromStoreAllcodes = new HashSet<StoreTrns>();
            //StoreTrnsMFromStoreAllcodes = new HashSet<StoreTrnsM>();
            //StoreTrnsMToStoreAllcodes = new HashSet<StoreTrnsM>();
            //StoreTrnsMType = new HashSet<StoreTrnsM>();
            //StoreTrnsODst = new HashSet<StoreTrnsO>();
            //StoreTrnsOInjure = new HashSet<StoreTrnsO>();
            //StoreTrnsToStoreAllcodes = new HashSet<StoreTrns>();
        }

        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal CashBeginDebit { get; set; }
        public decimal CashBeginCredit { get; set; }
        public decimal CheckBeginDebit { get; set; }
        public decimal CheckBeginCredit { get; set; }
        [Key]
        public int StoreAllcodesId { get; set; }
        public int? GroupfId { get; set; }
        public bool? Discdepend { get; set; }
        public decimal? Discount { get; set; }
        public bool? Isstoped { get; set; }
        public bool? Istax { get; set; }
        public decimal? Salestax { get; set; }
        public decimal? Cashlimit { get; set; }
        public int? PeriodLimit { get; set; }
        public bool? Isbalanced { get; set; }
        public DateTime? Createdate { get; set; }
        public int? Userid { get; set; }
        public decimal? StoreAllcodesOriginalId { get; set; }
        public decimal? StoreAllcodesIdCrm { get; set; }
        public bool? Availableforreservation { get; set; }
        public string Stoppednotes { get; set; }
        public bool? Storage { get; set; }
        public decimal? Storageid { get; set; }

        [ForeignKey("GroupfId")]
        public virtual Groupf Groupf { get; set; }
        [ForeignKey("Userid")]
        public virtual Users User { get; set; }
        //[ForeignKey("Personid")]
        public virtual Staff Staff { get; set; }
        //public virtual ICollection<Agriage> Agriage { get; set; }
        //public virtual ICollection<Agridata> Agridata { get; set; }
        //public virtual ICollection<Agriprocess> Agriprocess { get; set; }
        //public virtual ICollection<Conditionsbooklet> Conditionsbooklet { get; set; }
        ////public virtual ICollection<Financespec> FinancespecAnalysis { get; set; }
        ////public virtual ICollection<Financespec> FinancespecFdist { get; set; }
        ////public virtual ICollection<Financespec> FinancespecRep { get; set; }
        ////public virtual ICollection<Financespec> FinancespecTdist { get; set; }
        //public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegin { get; set; }
        //public virtual ICollection<StoreSubCodeSpec> StoreSubCodeSpec { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrnsCash { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrnsFromStoreAllcodes { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMFromStoreAllcodes { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMToStoreAllcodes { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMType { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsODst { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsOInjure { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrnsToStoreAllcodes { get; set; }
    }
}
