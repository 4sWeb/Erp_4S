using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Stage
    {
        public Stage()
        {
            Productstages = new HashSet<Productstage>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Saturday { get; set; }
        public decimal? Sunday { get; set; }
        public decimal? Monday { get; set; }
        public decimal? Tuesday { get; set; }
        public decimal? Wednesday { get; set; }
        public decimal? Thursday { get; set; }
        public decimal? Friday { get; set; }
        public decimal? Rank { get; set; }

        public virtual ICollection<Productstage> Productstages { get; set; }
    }
}
