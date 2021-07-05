using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MainCriterion
    {
        public MainCriterion()
        {
            HelpCriteria = new HashSet<HelpCriterion>();
        }

        public decimal Id { get; set; }
        public string Cname { get; set; }
        public string Tname { get; set; }
        public string Filtercol { get; set; }

        public virtual ICollection<HelpCriterion> HelpCriteria { get; set; }
    }
}
