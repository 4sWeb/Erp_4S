using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Perinstalmentgrossleftview2
    {
        public decimal? Formid { get; set; }
        public decimal Instalmentid { get; set; }
        public string Instalmentname { get; set; }
        public string Instalmentename { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Deducreasonsval { get; set; }
        public decimal? Factor { get; set; }
        public decimal? Instalmentvalue { get; set; }
        public decimal? Payed { get; set; }
        public decimal? Payedfixedval { get; set; }
        public decimal? Grossleft { get; set; }
        public short? Overallserial { get; set; }
        public decimal Punich { get; set; }
        public decimal? Earlypayment { get; set; }
        public decimal? Penaltyexemptionrate { get; set; }
        public decimal? Confirmed { get; set; }
        public decimal? Hafzatype { get; set; }
    }
}
