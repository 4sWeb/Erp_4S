using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financem
    {
        public Financem()
        {
            AcceptInFinancetrns = new HashSet<AcceptInFinancetrn>();
            Checks = new HashSet<Check>();
            Financedeps = new HashSet<Financedep>();
            Financeinstalments = new HashSet<Financeinstalment>();
            Financeinvdists = new HashSet<Financeinvdist>();
            Financialcancellations = new HashSet<Financialcancellation>();
            Hafzams = new HashSet<Hafzam>();
            LgFinances = new HashSet<LgFinance>();
            MultydistTemps = new HashSet<MultydistTemp>();
            Multydists = new HashSet<Multydist>();
            RentformFinances = new HashSet<RentformFinance>();
            Reschedules = new HashSet<Reschedule>();
            ServicesFinances = new HashSet<ServicesFinance>();
        }

        public decimal Id { get; set; }
        public DateTime? Trnsdate { get; set; }
        public DateTime? Fstamp { get; set; }
        public decimal? Branch { get; set; }
        public decimal? Trnscode { get; set; }
        public long? Trnsno { get; set; }
        public decimal? Period { get; set; }
        public string Documentno { get; set; }
        public int? Hafzamid { get; set; }
        public decimal? Purpose { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal? Tdistid { get; set; }
        public decimal? Repid { get; set; }
        public decimal? Analysisid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public decimal? Grossval { get; set; }
        public decimal? Netval { get; set; }
        public decimal? Commtax { get; set; }
        public decimal? Commtaxrate { get; set; }
        public decimal? Commdtax { get; set; }
        public decimal? Commtaxdrate { get; set; }
        public decimal? Salestax { get; set; }
        public decimal? Salestaxrate { get; set; }
        public decimal? Othertax { get; set; }
        public decimal? Othertaxrate { get; set; }
        public decimal? Penaltytax { get; set; }
        public decimal? Penaltyrate { get; set; }
        public string Transfertoname { get; set; }
        public string Transfertoacc { get; set; }
        public string Transfertobank { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Confirmed { get; set; }
        public int? Confirmedby { get; set; }
        public DateTime? Confirmdate { get; set; }
        public decimal? Storemid { get; set; }
        public int? Curridact { get; set; }
        public int? Curridlocal { get; set; }
        public decimal? Currrateacttrns { get; set; }
        public decimal? Netvalact { get; set; }
        public decimal? Grossvallocal { get; set; }
        public decimal? Netvallocal { get; set; }
        public string Taxnumber { get; set; }
        public string Fileno { get; set; }
        public string Financiername { get; set; }
        public string Financieraddress { get; set; }
        public string Mission { get; set; }
        public DateTime? Checkduedate { get; set; }
        public string Checknum { get; set; }
        public decimal? Tax41rate { get; set; }
        public decimal? Tax41value { get; set; }
        public string Tax41trnsnatural { get; set; }
        public string Invoicenum { get; set; }
        public string Attrvalue { get; set; }
        public string Attrvalueen { get; set; }
        public decimal? Cfinancedepspecid { get; set; }
        public decimal? Curriddiff { get; set; }

        public virtual StoreAllcode Analysis { get; set; }
        public virtual StoreAllsubcode BranchNavigation { get; set; }
        public virtual Currencym Curr { get; set; }
        public virtual StoreAllcode Fdist { get; set; }
        public virtual Financepupose PurposeNavigation { get; set; }
        public virtual StoreAllcode Rep { get; set; }
        public virtual StoreAllcode Tdist { get; set; }
        public virtual Financespec TrnscodeNavigation { get; set; }
        public virtual ICollection<AcceptInFinancetrn> AcceptInFinancetrns { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Financedep> Financedeps { get; set; }
        public virtual ICollection<Financeinstalment> Financeinstalments { get; set; }
        public virtual ICollection<Financeinvdist> Financeinvdists { get; set; }
        public virtual ICollection<Financialcancellation> Financialcancellations { get; set; }
        public virtual ICollection<Hafzam> Hafzams { get; set; }
        public virtual ICollection<LgFinance> LgFinances { get; set; }
        public virtual ICollection<MultydistTemp> MultydistTemps { get; set; }
        public virtual ICollection<Multydist> Multydists { get; set; }
        public virtual ICollection<RentformFinance> RentformFinances { get; set; }
        public virtual ICollection<Reschedule> Reschedules { get; set; }
        public virtual ICollection<ServicesFinance> ServicesFinances { get; set; }
    }
}
