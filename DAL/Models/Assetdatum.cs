using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Assetdatum
    {
        public decimal Id { get; set; }
        public string Assetcode { get; set; }
        public string Assetaname { get; set; }
        public decimal? Docvalue { get; set; }
        public string Assettrnsnamear { get; set; }
        public string Assettrnsnameen { get; set; }
        public decimal? Transtype { get; set; }
        public decimal? Transcode { get; set; }
        public decimal? Trnsvalue { get; set; }
        public DateTime? Transdate { get; set; }
        public string Accountcode { get; set; }
        public string Accountaname { get; set; }
        public decimal? Trnsaccount { get; set; }
        public string Notes { get; set; }
    }
}
