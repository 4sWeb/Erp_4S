using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesMetersReading
    {
        public decimal Id { get; set; }
        public decimal? ServicesInstitemServTypeId { get; set; }
        public DateTime? InDate { get; set; }
        public decimal? MeterReading { get; set; }
        public DateTime? InsertDate { get; set; }
        public decimal? CustStoreAllcodesIdnew { get; set; }
        public string IsAverageReading { get; set; }

        public virtual StoreAllcode CustStoreAllcodesIdnewNavigation { get; set; }
        public virtual ServicesInstitemServiceType ServicesInstitemServType { get; set; }
    }
}
