using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Journalcodesacc
    {
        public decimal Id { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? Journalcodeid { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual Journalcode Journalcode { get; set; }
    }
}
