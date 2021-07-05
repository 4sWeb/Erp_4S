using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financialcancellation
    {
        public decimal Id { get; set; }
        public decimal? Financialmid { get; set; }
        public decimal? Saleformid { get; set; }

        public virtual Financem Financialm { get; set; }
        public virtual Saleform Saleform { get; set; }
    }
}
