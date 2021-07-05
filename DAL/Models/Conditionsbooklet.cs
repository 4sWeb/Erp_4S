using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Conditionsbooklet
    {
        public decimal Id { get; set; }
        public decimal? Trnsno { get; set; }
        public decimal? Customerid { get; set; }
        public DateTime? Trnsdate { get; set; }
        public string Bookletno { get; set; }
        public string Paymentbanknum { get; set; }
        public decimal? Payed { get; set; }
        public bool? State { get; set; }
        public bool? Refunded { get; set; }
        public decimal? Userid { get; set; }

        public virtual StoreAllcode Customer { get; set; }
        public virtual User User { get; set; }
    }
}
