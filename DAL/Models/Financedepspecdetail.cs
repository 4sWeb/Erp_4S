using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financedepspecdetail
    {
        public decimal Id { get; set; }
        public decimal? Financedepspecid { get; set; }
        public decimal? Depfinancespecid { get; set; }
        public decimal? Getfrom { get; set; }
        public decimal? Getto { get; set; }
        public decimal? Fromfilter { get; set; }
        public decimal? Tofilter { get; set; }
        public decimal? Depslot { get; set; }

        public virtual Financespec Depfinancespec { get; set; }
        public virtual Financedepspec Financedepspec { get; set; }
    }
}
