using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VServicesInstitemReadingsrt
    {
        public DateTime? InDate { get; set; }
        public decimal? MeterReading { get; set; }
        public decimal? ServicesInstitemId { get; set; }
        public string Servicename { get; set; }
        public string UnitCode { get; set; }
        public string CustomerAname { get; set; }
        public string CustomerCode { get; set; }
        public string StageCode { get; set; }
        public string StageName { get; set; }
        public decimal? CustomerId { get; set; }
    }
}
