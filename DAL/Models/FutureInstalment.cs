using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FutureInstalment
    {
        public decimal? Saleformid { get; set; }
        public decimal? Year { get; set; }
        public decimal? Instval { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Descr { get; set; }
        public string Edescr { get; set; }
        public decimal? Instalmentpartsid { get; set; }
    }
}
