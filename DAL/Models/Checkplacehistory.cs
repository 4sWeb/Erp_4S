using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkplacehistory
    {
        public decimal Checkid { get; set; }
        public string Checkno { get; set; }
        public decimal? Tdistid { get; set; }
        public string Aname { get; set; }
        public decimal Id { get; set; }
        public decimal GroupfId { get; set; }
        public string Code { get; set; }
        public decimal Distid { get; set; }
        public decimal? CD { get; set; }
        public DateTime? Hstamp { get; set; }
        public decimal Hafzamid { get; set; }
        public decimal Hafzatype { get; set; }
        public string Hafzatypeaname { get; set; }
        public string Distname { get; set; }
        public int? Hafzano { get; set; }
    }
}
