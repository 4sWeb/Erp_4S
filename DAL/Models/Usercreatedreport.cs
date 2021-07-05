using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Usercreatedreport
    {
        public Usercreatedreport()
        {
            Saleformreports = new HashSet<Saleformreport>();
            Userreportsmenues = new HashSet<Userreportsmenue>();
        }

        public decimal Id { get; set; }
        public string Reportaname { get; set; }
        public string Reportename { get; set; }
        public string Reportfilepath { get; set; }
        public decimal? Userreportdatasourceid { get; set; }

        public virtual ICollection<Saleformreport> Saleformreports { get; set; }
        public virtual ICollection<Userreportsmenue> Userreportsmenues { get; set; }
    }
}
