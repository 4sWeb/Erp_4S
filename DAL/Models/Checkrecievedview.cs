using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkrecievedview
    {
        public decimal? Id { get; set; }
        public string Checkno { get; set; }
        public decimal? CD { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Duedate { get; set; }
        public string Isrecieved { get; set; }
    }
}
