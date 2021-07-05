using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Staffcust
    {
        public decimal Storecustid { get; set; }
        public string Custcode { get; set; }
        public string Custname { get; set; }
        public string Custename { get; set; }
        public string Staffcode { get; set; }
        public string Staffname { get; set; }
        public string Staffename { get; set; }
        public decimal? Staffid { get; set; }
    }
}
