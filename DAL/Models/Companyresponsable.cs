using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Companyresponsable
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal? Idnum { get; set; }
        public decimal? Companyinformationid { get; set; }
        public decimal? Isactive { get; set; }

        public virtual Companyinformation Companyinformation { get; set; }
    }
}
