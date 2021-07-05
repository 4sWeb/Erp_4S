using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Reservationitem
    {
        public decimal Id { get; set; }
        public decimal? StoreTrnOid { get; set; }
        public decimal? StoreItemId { get; set; }
        public decimal? StoreAllCodeid { get; set; }
        public decimal? Reservedqty { get; set; }

        public virtual StoreAllcode StoreAllCode { get; set; }
        public virtual StoreItem StoreItem { get; set; }
        public virtual StoreTrnsO StoreTrnO { get; set; }
    }
}
