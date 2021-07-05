using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dimension
    {
        public Dimension()
        {
            Dimensionlevels = new HashSet<Dimensionlevel>();
            Dimensionsdetails = new HashSet<Dimensionsdetail>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Dimensionlevel> Dimensionlevels { get; set; }
        public virtual ICollection<Dimensionsdetail> Dimensionsdetails { get; set; }
    }
}
