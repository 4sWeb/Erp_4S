using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Perrentinstalmentgrossleftview
    {
        public decimal? Formid { get; set; }
        public decimal Instalmentid { get; set; }
        public string Instalmentname { get; set; }
        public string Ename { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Instalmentvalue { get; set; }
        public decimal? Payed { get; set; }
        public decimal? Grossleft { get; set; }
    }
}
