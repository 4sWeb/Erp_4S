using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlSegment
    {
        public byte Rank { get; set; }
        public string Description { get; set; }
        public string Ttype { get; set; }
        public byte? Maxlen { get; set; }
        public string Value { get; set; }
        public int? FlexValueSetId { get; set; }
    }
}
