using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financespecprotection
    {
        public decimal RowId { get; set; }
        public decimal? Transcode { get; set; }
        public decimal? Branchid { get; set; }
        public DateTime? Protectiondate { get; set; }

        public virtual Financespec TranscodeNavigation { get; set; }
    }
}
