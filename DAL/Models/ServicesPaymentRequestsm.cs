using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesPaymentRequestsm
    {
        public ServicesPaymentRequestsm()
        {
            ServicesFinances = new HashSet<ServicesFinance>();
            ServicesPaymentRequests = new HashSet<ServicesPaymentRequest>();
            ServicesRequestsmFines = new HashSet<ServicesRequestsmFine>();
        }

        public decimal Id { get; set; }
        public DateTime? InDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? UnitId { get; set; }
        public decimal? CustId { get; set; }

        public virtual ServicesInstitem Unit { get; set; }
        public virtual ICollection<ServicesFinance> ServicesFinances { get; set; }
        public virtual ICollection<ServicesPaymentRequest> ServicesPaymentRequests { get; set; }
        public virtual ICollection<ServicesRequestsmFine> ServicesRequestsmFines { get; set; }
    }
}
