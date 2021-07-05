using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformdocattachment
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Docattachmentid { get; set; }
        public string Docname { get; set; }
        public string Docuniquename { get; set; }

        public virtual Documentsattachedtype Docattachment { get; set; }
        public virtual Saleform Saleform { get; set; }
    }
}
