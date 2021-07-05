using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleinstalmentsm
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Saleinstalmenttypesid { get; set; }
        public decimal? Val { get; set; }
        public string Instalmentsperiod { get; set; }
        public DateTime? Instalmentstartdate { get; set; }
        public DateTime? Instalmentenddate { get; set; }
        public decimal? Paymentperiod { get; set; }
        public decimal? Advance { get; set; }
        public decimal? Annualincrease { get; set; }
        public decimal? Maxtotal { get; set; }

        public virtual Saleform Saleform { get; set; }
    }
}
