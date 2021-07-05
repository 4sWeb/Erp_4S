using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Accountingentry
    {
        public Accountingentry()
        {
            Accountingentrydetails = new HashSet<Accountingentrydetail>();
        }

        public decimal Entryid { get; set; }
        public string Aremarks { get; set; }
        public string Eremarks { get; set; }
        public DateTime? Entrydate { get; set; }
        public decimal? Entrynumber { get; set; }
        public decimal? Entrytypeid { get; set; }
        public decimal? Recordnumber { get; set; }
        public decimal? Transactionnumber { get; set; }
        public decimal? Analyticalnumberid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Currencyrate { get; set; }

        public virtual Analyticalnumber Analyticalnumber { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Entrytype Entrytype { get; set; }
        public virtual ICollection<Accountingentrydetail> Accountingentrydetails { get; set; }
    }
}
