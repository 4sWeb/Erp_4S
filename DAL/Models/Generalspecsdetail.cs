using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Generalspecsdetail
    {
        public decimal Detailsid { get; set; }
        public decimal? Specid { get; set; }
        public decimal? Length { get; set; }
        public decimal? Levelnumber { get; set; }

        public virtual Generalspec Spec { get; set; }
    }
}
