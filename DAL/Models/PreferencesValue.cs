using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PreferencesValue
    {
        public string Prefcode { get; set; }
        public int? Preftype { get; set; }
        public decimal? Value { get; set; }
        public string Descr { get; set; }
    }
}
