using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Hafzao
    {
        public decimal Checkid { get; set; }
        public decimal Hafzaid { get; set; }

        public virtual Check Check { get; set; }
        public virtual Hafzam Hafza { get; set; }
    }
}
