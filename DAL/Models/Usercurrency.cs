using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Usercurrency
    {
        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Currencyid { get; set; }
        public bool? Defcurrency { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual User User { get; set; }
    }
}
