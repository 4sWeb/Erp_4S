using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Integratorrelation
    {
        public decimal Id { get; set; }
        public decimal? Trnsid { get; set; }
        public decimal? Integratortrnstypeid { get; set; }
        public decimal? Journalentriesmain { get; set; }
        public decimal? Transcode { get; set; }

        public virtual Integratortrnstype Integratortrnstype { get; set; }
        public virtual Journalentriesmain JournalentriesmainNavigation { get; set; }
    }
}
