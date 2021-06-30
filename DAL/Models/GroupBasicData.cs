using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class GroupBasicData
    {
        [Key]
        public int GroupBasicId { get; set; }
        public decimal? DetailsId { get; set; }
        public string Attribute { get; set; }
        public int? GroupfId { get; set; }
        public bool? Requiredfield { get; set; }
        public decimal? Rank { get; set; }
        public string Coltype { get; set; }
        public bool? Uniquefield { get; set; }
        public bool? Showincontract { get; set; }
        public decimal? Groupfdetailid { get; set; }
        public string Attributeen { get; set; }

        [ForeignKey("GroupfId")]
        public virtual Groupf Groupf { get; set; }
    }
}
