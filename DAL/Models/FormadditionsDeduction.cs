using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FormadditionsDeduction
    {
        public string Reason { get; set; }
        public string Ereason { get; set; }
        public decimal? Factor { get; set; }
        public string AffectSaleValue { get; set; }
        public decimal? Ontotalform { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Indate { get; set; }
    }
}
