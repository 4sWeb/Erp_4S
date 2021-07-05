using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financedep
    {
        public decimal Id { get; set; }
        public decimal? Pfinancemid { get; set; }
        public decimal? Cfinancemid { get; set; }
        public decimal? Financedepspecid { get; set; }
        public decimal? Netvalue { get; set; }
        public decimal? Committed { get; set; }
        public decimal? Depslot { get; set; }

        public virtual Financem Cfinancem { get; set; }
        public virtual Financedepspec Financedepspec { get; set; }
    }
}
