using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeacceptenceview
    {
        public decimal Id { get; set; }
        public decimal? TrnsId { get; set; }
        public decimal? AcceptId { get; set; }
        public decimal? IsAccepted { get; set; }
        public decimal? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Acceptdate { get; set; }
        public decimal? Commited { get; set; }
        public string Uname { get; set; }
        public string AcceptName { get; set; }
        public decimal? AcceptSerial { get; set; }
    }
}
