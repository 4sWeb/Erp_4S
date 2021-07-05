using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Companyinfo
    {
        public decimal Id { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public int? Appearance { get; set; }
        public decimal? Detailsid { get; set; }

        public virtual Detailsdataname Details { get; set; }
    }
}
