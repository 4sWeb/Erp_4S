using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Codelinkpartdetail
    {
        public decimal Id { get; set; }
        public decimal? Codelinkid { get; set; }
        public decimal? Storeallsubcodeid { get; set; }
        public decimal? Accountid { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual Codeslink Codelink { get; set; }
        public virtual StoreAllsubcode Storeallsubcode { get; set; }
    }
}
