using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleforminsprogram
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Instprogramid { get; set; }
        public decimal? Noofmonths { get; set; }
        public string Tableflag { get; set; }
        public decimal? Tableid { get; set; }

        public virtual Instprogram Instprogram { get; set; }
        public virtual Saleform Saleform { get; set; }
    }
}
