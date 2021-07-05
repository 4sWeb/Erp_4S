using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DefinePreference
    {
        public string Code { get; set; }
        public string Descr { get; set; }
        public string Defaultvalue { get; set; }
        public decimal Preftype { get; set; }
        public string App { get; set; }
    }
}
