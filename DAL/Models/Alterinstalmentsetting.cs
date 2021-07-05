using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Alterinstalmentsetting
    {
        public decimal? Id { get; set; }
        public decimal? Daysbeforeinstduedate { get; set; }
        public string Emailbady { get; set; }
        public string Emailsubject { get; set; }
    }
}
