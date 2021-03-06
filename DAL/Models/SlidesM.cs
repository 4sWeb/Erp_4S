using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SlidesM
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Ename { get; set; }
        public string Aname { get; set; }
        public decimal? SlideLength { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? MiniAmount { get; set; }
        public string AmountType { get; set; }
    }
}
