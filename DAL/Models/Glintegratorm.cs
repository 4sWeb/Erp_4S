using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Glintegratorm
    {
        public Glintegratorm()
        {
            Glintegratoros = new HashSet<Glintegratoro>();
        }

        public decimal Id { get; set; }
        public decimal? Integratortrnstypeid { get; set; }
        public decimal? Trnscode { get; set; }
        public string Trnstype { get; set; }
        public decimal? Entrynumber { get; set; }
        public decimal? Journalcodeid { get; set; }
        public string Entrydesc { get; set; }
        public bool? Getanalaysiscode { get; set; }
        public bool? Getdocnumber { get; set; }

        public virtual ICollection<Glintegratoro> Glintegratoros { get; set; }
    }
}
