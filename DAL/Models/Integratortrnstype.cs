using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Integratortrnstype
    {
        public Integratortrnstype()
        {
            Integratorrelations = new HashSet<Integratorrelation>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Integratorrelation> Integratorrelations { get; set; }
    }
}
