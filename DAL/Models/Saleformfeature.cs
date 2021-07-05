using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformfeature
    {
        public decimal? Saleformid { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public string InstprogramsId { get; set; }
        public string Ownercompany { get; set; }
    }
}
