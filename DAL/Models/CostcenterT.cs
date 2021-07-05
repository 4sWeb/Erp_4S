using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CostcenterT
    {
        public string Code { get; set; }
        public string Aname { get; set; }
        public decimal? Dimensionlevelsid { get; set; }
        public bool? Islastmaindimensions { get; set; }
        public bool? Isdetailed { get; set; }
        public string Parentcode { get; set; }
        public decimal? Levelid { get; set; }
    }
}
