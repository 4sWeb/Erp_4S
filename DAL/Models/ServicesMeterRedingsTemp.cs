using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesMeterRedingsTemp
    {
        public decimal? UnitId { get; set; }
        public decimal? ServicesInstitemServTypeId { get; set; }
        public DateTime? InDate { get; set; }
        public string IsAverageReading { get; set; }
        public decimal? ServicesId { get; set; }
        public decimal? CurrentReading { get; set; }
        public decimal? PreviousReading { get; set; }
        public decimal? Consumed { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string ServicesName { get; set; }
        public string UniqueId { get; set; }
        public DateTime? PreviousReadingIndate { get; set; }
        public decimal? CustStoreAllcodesId { get; set; }
        public string Stage { get; set; }
        public string PreviousIsaverage { get; set; }
        public string CurrentIslastReading { get; set; }
        public string ServicesEname { get; set; }
        public decimal? PreviousLastavgReading { get; set; }
    }
}
