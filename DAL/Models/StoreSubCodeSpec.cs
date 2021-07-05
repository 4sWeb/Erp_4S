using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreSubCodeSpec
    {
        public decimal? StoreAllcodesId { get; set; }
        public decimal SscsId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public decimal? GroupBasicId { get; set; }
        public string Attributeen { get; set; }

        public virtual StoreAllcode StoreAllcodes { get; set; }
    }
}
