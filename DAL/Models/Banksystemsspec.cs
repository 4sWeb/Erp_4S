using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Banksystemsspec
    {
        public decimal Id { get; set; }
        public decimal? Tempcheckduedatealerteriod { get; set; }
        public string Tempcheckduedatealerttype { get; set; }
    }
}
