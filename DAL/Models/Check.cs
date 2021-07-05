using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Check
    {
        public Check()
        {
            Checkrecieveds = new HashSet<Checkrecieved>();
            Financeinstalments = new HashSet<Financeinstalment>();
            Hafzaos = new HashSet<Hafzao>();
            RentformFinances = new HashSet<RentformFinance>();
            RescheduleCheckid2Navigations = new HashSet<Reschedule>();
            RescheduleChecks = new HashSet<Reschedule>();
        }

        public decimal Id { get; set; }
        public string Checkno { get; set; }
        public decimal? Branch { get; set; }
        public decimal? CD { get; set; }
        public int? Checkserial { get; set; }
        public decimal? Period { get; set; }
        public decimal? Checktype { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Duedate { get; set; }
        public string Beneficiary { get; set; }
        public string Bankname { get; set; }
        public decimal? Debtorid { get; set; }
        public decimal? Financemid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public decimal? Vendorid { get; set; }
        public decimal? Valuetrns { get; set; }
        public decimal? Valuelocal { get; set; }
        public decimal? Curridact { get; set; }

        public virtual StoreAllsubcode BranchNavigation { get; set; }
        public virtual Financetype CDNavigation { get; set; }
        public virtual Checktype ChecktypeNavigation { get; set; }
        public virtual Currencym Curr { get; set; }
        public virtual StoreAllcode Debtor { get; set; }
        public virtual Financem Financem { get; set; }
        public virtual Period PeriodNavigation { get; set; }
        public virtual StoreAllcode Vendor { get; set; }
        public virtual ICollection<Checkrecieved> Checkrecieveds { get; set; }
        public virtual ICollection<Financeinstalment> Financeinstalments { get; set; }
        public virtual ICollection<Hafzao> Hafzaos { get; set; }
        public virtual ICollection<RentformFinance> RentformFinances { get; set; }
        public virtual ICollection<Reschedule> RescheduleCheckid2Navigations { get; set; }
        public virtual ICollection<Reschedule> RescheduleChecks { get; set; }
    }
}
