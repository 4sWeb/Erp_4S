using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class IteminformationinitMod
    {
        public string Itemname { get; set; }
        public string Itemename { get; set; }
        public string Itemformcode { get; set; }
        public string Itemcode { get; set; }
        public decimal? Itemform { get; set; }
        public string Storename { get; set; }
        public string Storeename { get; set; }
        public string Storecode { get; set; }
        public decimal StoreItemsId { get; set; }
        public decimal StoreAllcodesId { get; set; }
        public decimal? Balance { get; set; }
        public string Unit { get; set; }
        public string Eunit { get; set; }
        public decimal Unitid { get; set; }
        public decimal? Storegroup { get; set; }
        public decimal? Itemgroup { get; set; }
        public decimal? Periodid { get; set; }
    }
}
