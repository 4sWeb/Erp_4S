using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlAccount
    {
        public GlAccount()
        {
            IntgAcccodesDetails = new HashSet<IntgAcccodesDetail>();
        }

        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public string Shortcode { get; set; }
        public string Longcode { get; set; }
        public bool? Islast { get; set; }
        public bool? Iscredit { get; set; }
        public bool? Islocked { get; set; }
        public decimal? Openingbalance { get; set; }
        public DateTime? Openingbalancedate { get; set; }
        public decimal? Reporttype { get; set; }
        public decimal? Alevel { get; set; }
        public decimal? Parentanalysis { get; set; }
        public decimal? Parentcategoryanalysis { get; set; }
        public decimal? Currency { get; set; }
        public decimal? Accounttype { get; set; }
        public decimal? Parentaccount { get; set; }
        public decimal? Parentcategoryaccount { get; set; }
        public decimal? Canbeanalyzed { get; set; }
        public string Accountclass { get; set; }
        public decimal? Destinationtype { get; set; }
        public bool? Closureaccount { get; set; }
        public bool? Isprivate { get; set; }
        public string StrOpeningbalancedate { get; set; }
        public string Branchcode { get; set; }

        public virtual ICollection<IntgAcccodesDetail> IntgAcccodesDetails { get; set; }
    }
}
