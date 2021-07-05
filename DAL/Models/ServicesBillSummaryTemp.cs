using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesBillSummaryTemp
    {
        public string UnitCode { get; set; }
        public string CustomerAname { get; set; }
        public decimal? Total { get; set; }
        public string UniqueId { get; set; }
        public string LayoutName { get; set; }
        public string StageCode { get; set; }
        public string StageName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string BuildCode { get; set; }
        public string BuildName { get; set; }
        public string FloorCode { get; set; }
        public string FloorName { get; set; }
    }
}
