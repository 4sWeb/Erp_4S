using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkrecieved
    {
        public decimal Id { get; set; }
        public decimal? Checkid { get; set; }
        public string Isrecieved { get; set; }

        public virtual Check Check { get; set; }
    }
}
