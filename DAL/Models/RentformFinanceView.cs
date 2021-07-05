using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class RentformFinanceView
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public string Installmentcode { get; set; }
        public DateTime? Installmentdate { get; set; }
        public decimal? Installmentvalue { get; set; }
        public string Institemcode { get; set; }
        public string StoreAllsubcodesname { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Paidval { get; set; }
        public decimal? Remainamount { get; set; }
    }
}
