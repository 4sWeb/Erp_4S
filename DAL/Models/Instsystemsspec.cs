using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instsystemsspec
    {
        public decimal Id { get; set; }
        public decimal? Tempreserveperiod { get; set; }
        public string Tempreserveperiodtype { get; set; }
        public string Filtercustomerbooklet { get; set; }
    }
}
