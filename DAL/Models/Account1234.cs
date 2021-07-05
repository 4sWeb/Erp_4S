using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Account1234
    {
        public string Ser { get; set; }
        public string AccountId { get; set; }
        public string Acccode { get; set; }
        public decimal? DebitVal { get; set; }
        public decimal? CreditVal { get; set; }
    }
}
