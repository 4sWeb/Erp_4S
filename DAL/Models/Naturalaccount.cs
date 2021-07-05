using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Naturalaccount
    {
        public Naturalaccount()
        {
            Journalentriesdetails = new HashSet<Journalentriesdetail>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Journalentriesdetail> Journalentriesdetails { get; set; }
    }
}
