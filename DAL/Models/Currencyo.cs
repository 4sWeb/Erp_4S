using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Currencyo
    {
        public DateTime? Indate { get; set; }
        public decimal? Rate { get; set; }
        public int Id { get; set; }
        public int? Currmid { get; set; }

        [ForeignKey("Currmid")]
        public virtual Currencym Currm { get; set; }
    }
}
