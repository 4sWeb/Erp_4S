using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Servicesdatesmonthlytmp
    {
        public string CustomerAname { get; set; }
        public string CustomerCode { get; set; }
        public string UnitCode { get; set; }
        public string LayoutName { get; set; }
        public string Stagename { get; set; }
        public decimal? Servicevalue { get; set; }
        public string Aservname { get; set; }
        public decimal? Fvalforservice { get; set; }
        public decimal? BenefitsValue { get; set; }
        public decimal? Total { get; set; }
        public decimal? Totalrequestsdebitprev { get; set; }
        public DateTime? InDate { get; set; }
    }
}
