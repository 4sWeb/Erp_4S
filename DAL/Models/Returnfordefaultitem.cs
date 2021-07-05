using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Returnfordefaultitem
    {
        public decimal StoreAllsubcodesId { get; set; }
        public decimal? Defaultitemid { get; set; }
        public string Aname { get; set; }
        public string Concentration { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? IPurchPrice { get; set; }
    }
}
