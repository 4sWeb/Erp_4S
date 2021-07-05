using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonLastSequence
    {
        public decimal Id { get; set; }
        public string Classname { get; set; }
        public decimal? Classsequence { get; set; }
    }
}
