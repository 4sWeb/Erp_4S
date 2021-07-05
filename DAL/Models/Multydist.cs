using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Multydist
    {
        public Multydist()
        {
            MultydistDimensions = new HashSet<MultydistDimension>();
        }

        public decimal? TransactionId { get; set; }
        public decimal? ExpId { get; set; }
        public decimal? CostId { get; set; }
        public decimal? AssetscodeId { get; set; }
        public decimal? FtId { get; set; }
        public decimal? DocumantationId { get; set; }
        public decimal? ShippedId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Notes { get; set; }
        public decimal? AppId { get; set; }
        public decimal Id { get; set; }
        public decimal? TransmId { get; set; }
        public decimal? Commited { get; set; }
        public string AssetscodeName { get; set; }
        public string CostName { get; set; }
        public decimal? Curr { get; set; }
        public decimal? Rate { get; set; }
        public bool? Neteffect { get; set; }
        public decimal? Stageid { get; set; }
        public decimal? Exptypesid { get; set; }

        public virtual Financem Transaction { get; set; }
        public virtual StoreTrnsM Transm { get; set; }
        public virtual ICollection<MultydistDimension> MultydistDimensions { get; set; }
    }
}
