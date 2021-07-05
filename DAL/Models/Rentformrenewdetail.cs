using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentformrenewdetail
    {
        public decimal Id { get; set; }
        public decimal? Rentformrenewid { get; set; }
        public decimal? Instcompid { get; set; }
        public decimal? Unitcount { get; set; }
        public decimal? Unitrentamount { get; set; }

        public virtual Institemcomp Instcomp { get; set; }
        public virtual Rentformrenew Rentformrenew { get; set; }
    }
}
