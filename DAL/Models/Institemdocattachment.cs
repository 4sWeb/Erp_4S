using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemdocattachment
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Docattachmentid { get; set; }
        public string Docname { get; set; }
        public string Docuniquename { get; set; }

        public virtual Documentsattachedtype Docattachment { get; set; }
    }
}
