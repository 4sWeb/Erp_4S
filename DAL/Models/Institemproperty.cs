using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemproperty
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? ProertyId { get; set; }
        public decimal? Allsubid { get; set; }
        public string Data { get; set; }
        public string Layoutcode { get; set; }

        public virtual Institem Institem { get; set; }
        public virtual Institemmaintypesproperty Proerty { get; set; }
    }
}
