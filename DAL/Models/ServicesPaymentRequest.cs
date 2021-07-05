using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesPaymentRequest
    {
        public ServicesPaymentRequest()
        {
            ServicesFinances = new HashSet<ServicesFinance>();
        }

        public decimal Id { get; set; }
        public decimal? ServicesInstitemServTypeId { get; set; }
        public DateTime? IndateFrom { get; set; }
        public DateTime? IndateTo { get; set; }
        public decimal? PreviousValue { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ServunitId { get; set; }
        public string Servtype { get; set; }
        public DateTime? RecordingDate { get; set; }
        public DateTime? LastEdit { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? ServicesPaymentRequestsmId { get; set; }
        public string DepositBenefits { get; set; }
        public string IsInitial { get; set; }
        public string IsDebtor { get; set; }
        public DateTime? ActualIndateTo { get; set; }
        public decimal? MDelay { get; set; }
        public string IsAverageReading { get; set; }

        public virtual ServicesInstitemServiceType ServicesInstitemServType { get; set; }
        public virtual ServicesPaymentRequestsm ServicesPaymentRequestsm { get; set; }
        public virtual ICollection<ServicesFinance> ServicesFinances { get; set; }
    }
}
