using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreSubCodeSpec
    {
        public int? StoreAllcodesId { get; set; }
        [Key]
        public int SscsId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public decimal? GroupBasicId { get; set; }
        public string Attributeen { get; set; }

        [ForeignKey("StoreAllcodesId")]
        public virtual StoreAllcodes StoreAllcodes { get; set; }
    }
}
