using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformreport
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Userreportid { get; set; }

        public virtual Saleform Saleform { get; set; }
        public virtual Usercreatedreport Userreport { get; set; }
    }
}
