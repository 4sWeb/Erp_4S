using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemcheck
    {
        public decimal Id { get; set; }
        public decimal? Transid { get; set; }
        public decimal? Checkid { get; set; }
        public string Paytype { get; set; }
        public decimal? Installmentid { get; set; }
        public decimal? Fval { get; set; }

        public virtual Institemcompinstpay Installment { get; set; }
    }
}
