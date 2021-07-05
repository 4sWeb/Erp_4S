using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Convlegalaffair
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime? Convdate { get; set; }
        public string Convreason { get; set; }

        public virtual Saleform Saleform { get; set; }
    }
}
