using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class AcceptInTrns
    {
        [Key]
        public int Id { get; set; }
        public int? TrnsId { get; set; }
        public int? AcceptId { get; set; }
        public decimal? IsAccepted { get; set; }
        public int? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Acceptdate { get; set; }
        public decimal? Commited { get; set; }

        [ForeignKey("AcceptId")]
        public virtual StoreTrnsAccept Accept { get; set; }
        [ForeignKey("TrnsId")]
        public virtual StoreTrnsM Trns { get; set; }
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }
    }
}
