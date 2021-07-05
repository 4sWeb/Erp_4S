using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AcceptInsaleform
    {
        public decimal Id { get; set; }
        public decimal? SaleformAcceptId { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Isaccepted { get; set; }
        public DateTime? Acceptdate { get; set; }

        public virtual SaleformAccept SaleformAccept { get; set; }
        public virtual User User { get; set; }
    }
}
