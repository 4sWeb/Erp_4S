using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeallcodesattachment
    {
        public decimal Id { get; set; }
        public decimal? Storeallcodesid { get; set; }
        public decimal? Attachmentid { get; set; }
        public string Name { get; set; }
        public string Uniquename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Documentsattachedtype Attachment { get; set; }
        public virtual StoreAllcode Storeallcodes { get; set; }
    }
}
