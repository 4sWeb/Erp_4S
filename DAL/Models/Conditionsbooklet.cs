using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Conditionsbooklet
    {
        public int Id { get; set; }
        public decimal? Trnsno { get; set; }
        public int? Customerid { get; set; }
        public DateTime? Trnsdate { get; set; }
        public string Bookletno { get; set; }
        public string Paymentbanknum { get; set; }
        public decimal? Payed { get; set; }
        public bool? State { get; set; }
        public bool? Refunded { get; set; }
        public int? Userid { get; set; }
        [ForeignKey("Customerid")]
        public virtual StoreAllcodes Customer { get; set; }
        [ForeignKey("Userid")]
        public virtual Users User { get; set; }
    }
}
