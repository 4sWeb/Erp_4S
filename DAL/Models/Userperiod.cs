using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userperiod
    {
        public decimal Userid { get; set; }
        public decimal Periodid { get; set; }

        public virtual Period Period { get; set; }
        public virtual User User { get; set; }
    }
}
