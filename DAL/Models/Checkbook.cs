using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkbook
    {
        public Checkbook()
        {
            Checkbookdetails = new HashSet<Checkbookdetail>();
        }

        public decimal Id { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? Checkcount { get; set; }
        public string Checkserial { get; set; }

        public virtual StoreAllcode Bank { get; set; }
        public virtual ICollection<Checkbookdetail> Checkbookdetails { get; set; }
    }
}
