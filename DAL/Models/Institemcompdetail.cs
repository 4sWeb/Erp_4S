using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemcompdetail
    {
        public decimal Id { get; set; }
        public long? Unitcount { get; set; }
        public decimal? Unitrentamount { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Institemcompid { get; set; }
        public decimal? Rentformrenewid { get; set; }
        public string Rooms { get; set; }

        public virtual Institemcomp Institemcomp { get; set; }
        public virtual Rentform Rentform { get; set; }
        public virtual Rentformrenew Rentformrenew { get; set; }
    }
}
