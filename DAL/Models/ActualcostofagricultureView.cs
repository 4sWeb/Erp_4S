using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ActualcostofagricultureView
    {
        public decimal? ActcostcenterId { get; set; }
        public string Actcostcentername { get; set; }
        public decimal? Actoperationid { get; set; }
        public string Actoperation { get; set; }
        public decimal? Actqty { get; set; }
        public decimal? Actcostval { get; set; }
        public decimal? Period { get; set; }
        public decimal? BranchId { get; set; }
    }
}
