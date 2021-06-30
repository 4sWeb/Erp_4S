using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Storedsttypes
    {
        public int? Trnscode { get; set; }
        public string Ft { get; set; }
        public decimal? Dsttype { get; set; }
        public decimal? Rank { get; set; }
        [Key]
        public int Dstid { get; set; }

        [ForeignKey("Trnscode")]
        public virtual StoreTrns TrnscodeNavigation { get; set; }
    }
}
