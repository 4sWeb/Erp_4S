using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Codechange
    {
        public decimal Id { get; set; }
        public string Oldcode { get; set; }
        public string Newcode { get; set; }
        public decimal? Oldformid { get; set; }
        public decimal? Newformid { get; set; }
        public decimal? Recid { get; set; }
    }
}
