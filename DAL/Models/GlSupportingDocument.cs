using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlSupportingDocument
    {
        public decimal Id { get; set; }
        public string Serial { get; set; }
        public DateTime? GlSupportingDocumentDate { get; set; }
        public string Notes { get; set; }
        public decimal? Documenttype { get; set; }
        public decimal? Mastertransaction { get; set; }
        public DateTime? Docdate { get; set; }
    }
}
