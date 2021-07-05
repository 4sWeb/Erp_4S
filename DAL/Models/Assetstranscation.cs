using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Assetstranscation
    {
        public decimal Id { get; set; }
        public decimal? Code { get; set; }
        public decimal? Transtype { get; set; }
        public DateTime? Transdate { get; set; }
        public decimal? Assetid { get; set; }
        public decimal? Trnsvalue { get; set; }
        public decimal? Trnsaccount { get; set; }
        public string Notes { get; set; }
        public decimal? Periodid { get; set; }
        public DateTime? Lastdepdate { get; set; }
        public decimal? Trnsaccount2 { get; set; }
        public decimal? Typeofexhaustion { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Period Period { get; set; }
        public virtual Assetstrnstype TranstypeNavigation { get; set; }
        public virtual Accountstree Trnsaccount2Navigation { get; set; }
        public virtual Accountstree TrnsaccountNavigation { get; set; }
    }
}
