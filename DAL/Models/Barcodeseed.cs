using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Barcodeseed
    {
        public decimal Id { get; set; }
        public decimal? Startserial { get; set; }
        public decimal? Endserial { get; set; }
        public string Clientname { get; set; }
        public string Serialcode { get; set; }
    }
}
