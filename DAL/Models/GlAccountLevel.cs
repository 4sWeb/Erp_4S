using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlAccountLevel
    {
        public decimal Id { get; set; }
        public long? Levelno { get; set; }
        public long? Length { get; set; }
        public bool? Islastlevel { get; set; }
        public decimal? Accounttype { get; set; }
    }
}
