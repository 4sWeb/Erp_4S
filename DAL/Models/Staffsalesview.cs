using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Staffsalesview
    {
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Code { get; set; }
        public decimal? Saleformnum { get; set; }
        public decimal? Reservedunitsnum { get; set; }
    }
}
