using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Hafzadisttype
    {
        public decimal Hafzatype { get; set; }
        public decimal Disttype { get; set; }
        public string Ft { get; set; }
        public byte? Rank { get; set; }
        public string Reserved { get; set; }
    }
}
