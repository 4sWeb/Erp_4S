using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlMasterBudget
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public string Serial { get; set; }
        public DateTime? GlMasterBudgetDate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Notes { get; set; }
        public bool? Flag { get; set; }
    }
}
