using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstalmentsNotFullyPaid
    {
        public decimal? Saleformid { get; set; }
        public decimal? Year { get; set; }
        public decimal? Instval { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? Ff { get; set; }
        public decimal? Instalmentownerid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
    }
}
