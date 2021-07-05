using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DbUpdate
    {
        public decimal Dbupdateid { get; set; }
        public decimal? Lastver { get; set; }
        public string Filename { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
