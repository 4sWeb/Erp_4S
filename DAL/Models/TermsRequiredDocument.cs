using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TermsRequiredDocument
    {
        public decimal Id { get; set; }
        public decimal? Termcode { get; set; }
        public string Briefdesc { get; set; }
        public string Memo { get; set; }
        public string Type { get; set; }
    }
}
