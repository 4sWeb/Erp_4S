using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesFinance
    {
        public decimal Id { get; set; }
        public decimal? Trnsid { get; set; }
        public decimal? Checkid { get; set; }
        public string Paytype { get; set; }
        public decimal? ServPaymentRequestsmId { get; set; }
        public decimal? Fval { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? CustId { get; set; }
        public decimal? ServPaymentRequestsId { get; set; }

        public virtual ServicesPaymentRequest ServPaymentRequests { get; set; }
        public virtual ServicesPaymentRequestsm ServPaymentRequestsm { get; set; }
        public virtual Financem Trns { get; set; }
    }
}
