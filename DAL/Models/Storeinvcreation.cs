using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeinvcreation
    {
        public decimal Id { get; set; }
        public decimal? Storeinvid { get; set; }
        public decimal? StoreMId { get; set; }
        public string Transcode { get; set; }
        public string Docno { get; set; }
    }
}
