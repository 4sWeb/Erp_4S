using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformtype
    {
        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Code { get; set; }
    }
}
