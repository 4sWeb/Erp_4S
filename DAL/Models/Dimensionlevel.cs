using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dimensionlevel
    {
        public Dimensionlevel()
        {
            Dimensionsdetails = new HashSet<Dimensionsdetail>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Length { get; set; }
        public decimal? Levelno { get; set; }
        public decimal? Dimensionsid { get; set; }

        public virtual Dimension Dimensions { get; set; }
        public virtual ICollection<Dimensionsdetail> Dimensionsdetails { get; set; }
    }
}
