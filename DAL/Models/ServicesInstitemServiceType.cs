using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesInstitemServiceType
    {
        public ServicesInstitemServiceType()
        {
            ServicesMetersReadings = new HashSet<ServicesMetersReading>();
            ServicesPaymentRequests = new HashSet<ServicesPaymentRequest>();
        }

        public decimal Id { get; set; }
        public decimal? ServicesTypeId { get; set; }
        public decimal? ServicesInstitemId { get; set; }
        public string Servicesstatus { get; set; }

        public virtual ServicesType ServicesType { get; set; }
        public virtual ICollection<ServicesMetersReading> ServicesMetersReadings { get; set; }
        public virtual ICollection<ServicesPaymentRequest> ServicesPaymentRequests { get; set; }
    }
}
