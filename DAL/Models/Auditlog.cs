using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Auditlog
    {
        public int Auditlogid { get; set; }
        public string Transcode { get; set; }
        public int? Transid { get; set; }
        public string Branchcode { get; set; }
        public string Transtype { get; set; }
        public string Transtypedetail { get; set; }
        public string Eventtype { get; set; }
        public int? Periodid { get; set; }
        public string Ip { get; set; }
        public string Userid { get; set; }
        public DateTime? Eventdate { get; set; }
    }
}
