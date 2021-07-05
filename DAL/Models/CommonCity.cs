using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonCity
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool? Isdefault { get; set; }
        public decimal? Country { get; set; }
        public string Englishdescription { get; set; }
        public string Section { get; set; }
        public string Region { get; set; }
    }
}
