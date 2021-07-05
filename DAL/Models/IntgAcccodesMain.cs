using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class IntgAcccodesMain
    {
        public IntgAcccodesMain()
        {
            IntgAcccodesDetails = new HashSet<IntgAcccodesDetail>();
        }

        public int Id { get; set; }
        public string IntgDesc { get; set; }
        public decimal? AccountId { get; set; }
        public string AcccodeType { get; set; }
        public int? AgentType { get; set; }
        public string Acccode { get; set; }
        public string Compcode { get; set; }

        public virtual ICollection<IntgAcccodesDetail> IntgAcccodesDetails { get; set; }
    }
}
