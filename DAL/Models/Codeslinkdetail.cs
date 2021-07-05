using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Codeslinkdetail
    {
        public decimal Id { get; set; }
        public decimal? Codelinksid { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? StoreAllcodeid { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual Codeslink Codelinks { get; set; }
        public virtual StoreAllcode StoreAllcode { get; set; }
    }
}
