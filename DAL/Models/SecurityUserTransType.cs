using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityUserTransType
    {
        public decimal Id { get; set; }
        public decimal? Userprivilege { get; set; }
        public decimal? Transtype { get; set; }
    }
}
