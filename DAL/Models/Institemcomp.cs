using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemcomp
    {
        public Institemcomp()
        {
            Institemcompdetails = new HashSet<Institemcompdetail>();
            Rentformrenewdetails = new HashSet<Rentformrenewdetail>();
        }

        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public string Unitno { get; set; }
        public string Unitscount { get; set; }
        public decimal? Unitmaxamount { get; set; }
        public decimal? Totalamount { get; set; }
        public decimal? Unitminamount { get; set; }
        public decimal? Uintsize { get; set; }
        public long? Unitfloor { get; set; }
        public long? Unitrooms { get; set; }
        public decimal? Dimensiondetailsid { get; set; }
        public string Electcounter { get; set; }
        public string Watcounter { get; set; }

        public virtual Dimensionsdetail Dimensiondetails { get; set; }
        public virtual Institem Institem { get; set; }
        public virtual ICollection<Institemcompdetail> Institemcompdetails { get; set; }
        public virtual ICollection<Rentformrenewdetail> Rentformrenewdetails { get; set; }
    }
}
