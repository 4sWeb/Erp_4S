using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Commissionrule
    {
        public int Id { get; set; }
        public int? Stafflevelsid { get; set; }
        public int? Duestaffclassid { get; set; }
        public int? Duestaffsubclassid { get; set; }
        public decimal? Cratio { get; set; }
    }
}
