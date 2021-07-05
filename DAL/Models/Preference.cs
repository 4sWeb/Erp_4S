using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Preference
    {
        public decimal Userid { get; set; }
        public string Prefcode { get; set; }
        public string Value { get; set; }
        public decimal Preftype { get; set; }
    }
}
