using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Hafzam
    {
        public Hafzam()
        {
            Hafzaos = new HashSet<Hafzao>();
        }

        public decimal Id { get; set; }
        public DateTime? Hafzadate { get; set; }
        public DateTime? Hstamp { get; set; }
        public decimal? CD { get; set; }
        public decimal? Hbranch { get; set; }
        public decimal? Hafzatype { get; set; }
        public int? Hafzano { get; set; }
        public decimal? Period { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal? Tdistid { get; set; }
        public string Documentno { get; set; }
        public decimal? Cost { get; set; }
        public string Remark { get; set; }
        public decimal? Trnscode { get; set; }
        public decimal? Collectiondealydays { get; set; }
        public decimal? Financemid { get; set; }
        public decimal? Bankexpenses { get; set; }

        public virtual Financetype CDNavigation { get; set; }
        public virtual StoreAllcode Fdist { get; set; }
        public virtual Financem Financem { get; set; }
        public virtual Hafzaspec HafzatypeNavigation { get; set; }
        public virtual StoreAllsubcode HbranchNavigation { get; set; }
        public virtual Period PeriodNavigation { get; set; }
        public virtual StoreAllcode Tdist { get; set; }
        public virtual Financespec TrnscodeNavigation { get; set; }
        public virtual ICollection<Hafzao> Hafzaos { get; set; }
    }
}
