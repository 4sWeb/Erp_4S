using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesBenefit
    {
        public decimal Id { get; set; }
        public decimal? DepositBenefitsRetio { get; set; }
        public DateTime? CalculationDate { get; set; }
        public decimal? MDelay { get; set; }
    }
}
