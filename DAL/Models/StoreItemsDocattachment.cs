using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsDocattachment
    {
        public decimal Id { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Docattachmentid { get; set; }
        public string Docname { get; set; }
        public string Docuniquename { get; set; }
        public bool? Docattachmentlogo { get; set; }

        public virtual Documentsattachedtype Docattachment { get; set; }
        public virtual StoreItem StoreItems { get; set; }
    }
}
