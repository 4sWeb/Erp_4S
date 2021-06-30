using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Dimensions
    {
        public Dimensions()
        {
            //Dimensionlevels = new HashSet<Dimensionlevels>();
            //Dimensionsdetails = new HashSet<Dimensionsdetails>();
        }

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        //public virtual ICollection<Dimensionlevels> Dimensionlevels { get; set; }
        //public virtual ICollection<Dimensionsdetails> Dimensionsdetails { get; set; }
    }
}
