using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SalesCommisionTemp
    {
        public string Id { get; set; }
        public decimal? StaffId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Todate { get; set; }
        public decimal? SlideMId { get; set; }
        public string ApplyTo { get; set; }
        public decimal? SumTotal { get; set; }
        public decimal? Commision { get; set; }
        public string ApartmentCode { get; set; }
        public string Stagename { get; set; }
        public string Buildingname { get; set; }
    }
}
