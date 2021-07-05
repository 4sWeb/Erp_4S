using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsmattachment
    {
        public decimal Id { get; set; }
        public decimal? Storetrnsmid { get; set; }
        public decimal? Attachmentid { get; set; }
        public string Name { get; set; }
        public string Uniquename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Documentsattachedtype Attachment { get; set; }
        public virtual StoreTrnsM Storetrnsm { get; set; }
    }
}
