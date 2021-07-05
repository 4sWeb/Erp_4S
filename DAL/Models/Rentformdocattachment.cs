using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentformdocattachment
    {
        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Docattachmentid { get; set; }
        public string Docname { get; set; }
        public string Docuniquename { get; set; }
        public DateTime? Dateadded { get; set; }

        public virtual Documentsattachedtype Docattachment { get; set; }
        public virtual Rentform Rentform { get; set; }
    }
}
