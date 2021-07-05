using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Clientinstitem
    {
        public decimal? Id { get; set; }
        public string Ownername { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Saleformid { get; set; }
        public string Institemcode { get; set; }
        public string Name { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
    }
}
