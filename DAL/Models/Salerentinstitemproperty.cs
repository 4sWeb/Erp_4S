using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Salerentinstitemproperty
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? ProertyId { get; set; }
        public decimal? Allsubid { get; set; }
        public string Data { get; set; }

        public virtual Salerentinstitem Institem { get; set; }
        public virtual Institemmaintypesproperty Proerty { get; set; }
    }
}
