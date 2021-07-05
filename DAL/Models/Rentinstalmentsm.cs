using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentinstalmentsm
    {
        public Rentinstalmentsm()
        {
            Rentinstalmentsos = new HashSet<Rentinstalmentso>();
        }

        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Val { get; set; }
        public string Instalmentsperiod { get; set; }
        public DateTime? Instalmentstartdate { get; set; }
        public DateTime? Instalmentenddate { get; set; }
        public decimal? Paymentperiod { get; set; }
        public decimal? Advance { get; set; }
        public decimal? Annualincrease { get; set; }
        public decimal? Maxtotal { get; set; }
        public decimal? Advancerefundvalperinst { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? Insurancerefundvalperinst { get; set; }
        public DateTime? Insuranceinststratdate { get; set; }
        public string Anuualtype { get; set; }
        public string Annualincreasetype { get; set; }
        public decimal? Rentinstalmenttypesid { get; set; }
        public decimal? Rentperiodid { get; set; }
        public string Notes { get; set; }

        public virtual Rentform Rentform { get; set; }
        public virtual Rentinstalmenttype Rentinstalmenttypes { get; set; }
        public virtual Rentperiod Rentperiod { get; set; }
        public virtual ICollection<Rentinstalmentso> Rentinstalmentsos { get; set; }
    }
}
