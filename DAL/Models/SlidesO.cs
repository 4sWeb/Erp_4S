using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SlidesO
    {
        public decimal Id { get; set; }
        public decimal? SlidesMId { get; set; }
        public decimal? AmounFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public decimal? Amount { get; set; }
        public string AmountType { get; set; }
    }
}
