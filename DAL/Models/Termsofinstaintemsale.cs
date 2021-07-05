using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Termsofinstaintemsale
    {
        public decimal Id { get; set; }
        public decimal? Maximinnumunits { get; set; }
        public decimal? Institemmaintypesid { get; set; }

        public virtual Institemmaintype Institemmaintypes { get; set; }
    }
}
