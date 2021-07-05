using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vinvcodedetailsinformation
    {
        public decimal? Codetype { get; set; }
        public decimal TrnsCode { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public string Disttype { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
    }
}
