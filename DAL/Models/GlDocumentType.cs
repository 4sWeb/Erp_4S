using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlDocumentType
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public bool? Islocked { get; set; }
    }
}
