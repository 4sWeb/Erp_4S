using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesRequestsmFine
    {
        public decimal Id { get; set; }
        public decimal? ServicesPaymentRequestsmId { get; set; }
        public decimal? ServicesFinesId { get; set; }
        public decimal? CalculationRatio { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalDebit { get; set; }
        public DateTime? IndateTo { get; set; }
        public DateTime? RecordingDate { get; set; }

        public virtual ServicesFine ServicesFines { get; set; }
        public virtual ServicesPaymentRequestsm ServicesPaymentRequestsm { get; set; }
    }
}
