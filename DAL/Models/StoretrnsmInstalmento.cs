using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoretrnsmInstalmento
    {
        public decimal Id { get; set; }
        public decimal? StoreTrnsMId { get; set; }
        public decimal? Val { get; set; }
        public decimal? Increaseval { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Instalmentpartsid { get; set; }
        public byte? Subserial { get; set; }
        public short? Overallserial { get; set; }
        public decimal? Penaltyexemptionrate { get; set; }
        public decimal? Instprogramid { get; set; }
        public decimal? Noofmonths { get; set; }
        public string Serialname { get; set; }
        public string Instalmentname { get; set; }
        public string Serialename { get; set; }
        public string Instalmentename { get; set; }
        public decimal? Instalmentbenfitvalue { get; set; }
        public decimal? Instalmentvalueonly { get; set; }
        public decimal? StoretrnsmInstalmentsmid { get; set; }

        public virtual Instalmentpart Instalmentparts { get; set; }
        public virtual Instprogram Instprogram { get; set; }
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        public virtual StoretrnsmInstalmentsm StoretrnsmInstalmentsm { get; set; }
    }
}
