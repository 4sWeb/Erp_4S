using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class HelpCriterion
    {
        public int FId { get; set; }
        public decimal FC { get; set; }
        public string FFname { get; set; }
        public bool? FCriteria { get; set; }
        public bool? FShow { get; set; }
        public string FAlias { get; set; }
        public string FFtype { get; set; }
        public string FView { get; set; }
        public string FViewText { get; set; }
        public string FViewValue { get; set; }
        public bool? FInclude { get; set; }
        public decimal? Rank { get; set; }

        public virtual MainCriterion FCNavigation { get; set; }
    }
}
