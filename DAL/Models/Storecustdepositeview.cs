using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storecustdepositeview
    {
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? CustId { get; set; }
    }
}
