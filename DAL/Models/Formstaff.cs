using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Formstaff
    {
        public decimal? Id { get; set; }
        public string DocNo { get; set; }
        public decimal? Staff { get; set; }
        public decimal? Formstatustypes { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Flag { get; set; }
    }
}
