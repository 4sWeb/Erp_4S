using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financeinvspec
    {
        public decimal RowId { get; set; }
        public decimal? Transcode { get; set; }
        public decimal? Strid { get; set; }
        public string FT { get; set; }

        public virtual StoreTrn Str { get; set; }
        public virtual Financespec TranscodeNavigation { get; set; }
    }
}
