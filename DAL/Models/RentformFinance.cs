using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class RentformFinance
    {
        public decimal Id { get; set; }
        public decimal? Installmentid { get; set; }
        public decimal? Paidamount { get; set; }
        public decimal? Trnasid { get; set; }
        public decimal? Checkid { get; set; }
        public string Paytype { get; set; }

        public virtual Check Check { get; set; }
        public virtual Institemcompinstpay Installment { get; set; }
        public virtual Financem Trnas { get; set; }
    }
}
