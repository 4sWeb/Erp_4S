using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsfromtrn
    {
        public decimal Id { get; set; }
        public decimal? TrnsCodeM { get; set; }
        public decimal? TrnsCodeS { get; set; }
        public bool? ChangeSides { get; set; }
        public bool? SamePrice { get; set; }
        public bool? SameNum { get; set; }
        public bool? SameDep { get; set; }
        public bool? SameStageNum { get; set; }
        public bool? NoMessage { get; set; }
        public bool? Items { get; set; }
        public bool? UseSecretariat { get; set; }
        public bool? UseMatrial { get; set; }
        public bool? UseTrnsMatrial { get; set; }
        public bool? GetMatrialTrns { get; set; }
        public bool? GetWorkeNum { get; set; }
        public decimal? QtyFunction { get; set; }
        public decimal? PlanType { get; set; }
        public decimal? Serial { get; set; }
        public bool? Reservation { get; set; }
        public int? Docnodep { get; set; }
        public bool? Depsides { get; set; }
        public bool? Depdoc { get; set; }

        public virtual StoreTrn TrnsCodeMNavigation { get; set; }
        public virtual StoreTrn TrnsCodeSNavigation { get; set; }
    }
}
