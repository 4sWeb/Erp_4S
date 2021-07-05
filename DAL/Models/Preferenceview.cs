using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Preferenceview
    {
        public string Prefcode { get; set; }
        public decimal Userid { get; set; }
        public string Value { get; set; }
        public decimal Preftype { get; set; }
        public string Descr { get; set; }
    }
}
