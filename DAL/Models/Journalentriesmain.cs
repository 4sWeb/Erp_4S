using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Journalentriesmain
    {
        public Journalentriesmain()
        {
            Integratorrelations = new HashSet<Integratorrelation>();
            Journalentriesdetails = new HashSet<Journalentriesdetail>();
        }

        public decimal Id { get; set; }
        public decimal Journalcodesid { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Entynumber { get; set; }
        public string Docnumber { get; set; }
        public decimal? StoreAllcodesid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Conversionrate { get; set; }
        public string Entydesc { get; set; }
        public bool? Iscurrencydiff { get; set; }
        public bool? Isposted { get; set; }
        public decimal? Journalentrytypeid { get; set; }
        public decimal? Periodid { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual Journalcode Journalcodes { get; set; }
        public virtual StoreAllcode StoreAllcodes { get; set; }
        public virtual ICollection<Integratorrelation> Integratorrelations { get; set; }
        public virtual ICollection<Journalentriesdetail> Journalentriesdetails { get; set; }
    }
}
