using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Sumdiscountstoinstalment
    {
        public decimal? Discounts { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Instalmentid { get; set; }
    }
}
