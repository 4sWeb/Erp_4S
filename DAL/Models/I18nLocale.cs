using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class I18nLocale
    {
        public decimal Id { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Variant { get; set; }
        public string Code { get; set; }
        public bool? Isdefault { get; set; }
    }
}
