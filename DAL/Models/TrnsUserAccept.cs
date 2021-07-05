using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TrnsUserAccept
    {
        public decimal AcceptId { get; set; }
        public decimal Userid { get; set; }

        public virtual StoreTrnsAccept Accept { get; set; }
        public virtual User User { get; set; }
    }
}
