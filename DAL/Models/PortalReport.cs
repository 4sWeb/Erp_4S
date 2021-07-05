using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PortalReport
    {
        public decimal Id { get; set; }
        public string Databasename { get; set; }
        public string Reportname { get; set; }
        public string Reportnamear { get; set; }
        public string Reportfilename { get; set; }
        public decimal? Roleid { get; set; }
    }
}
