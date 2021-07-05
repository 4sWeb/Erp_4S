using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userreportsmenue
    {
        public decimal Id { get; set; }
        public decimal? Reportid { get; set; }
        public decimal? Applicationid { get; set; }
        public decimal? Menuelevel { get; set; }
        public decimal? Menueparentid { get; set; }
        public decimal? Status { get; set; }
        public string Overrideaname { get; set; }
        public string Overrideename { get; set; }

        public virtual Application Application { get; set; }
        public virtual Usercreatedreport Report { get; set; }
    }
}
