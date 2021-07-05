using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesPaymenRequest
    {
        public decimal UnitId { get; set; }
        public string UnitCode { get; set; }
        public decimal? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAname { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? IndateFrom { get; set; }
        public DateTime? IndateTo { get; set; }
        public decimal? PaymentrequestsmId { get; set; }
        public decimal PaymentrequestsId { get; set; }
        public decimal? JoinId { get; set; }
        public decimal? PreviousValue { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? Amount { get; set; }
        public string ServiceType { get; set; }
        public decimal? ServicePrice { get; set; }
        public string IsdepositBenefits { get; set; }
        public decimal? MeasureUnitId { get; set; }
        public string MeasureUnit { get; set; }
    }
}
