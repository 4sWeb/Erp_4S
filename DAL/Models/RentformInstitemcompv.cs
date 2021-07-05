using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class RentformInstitemcompv
    {
        public decimal Id { get; set; }
        public decimal Institemcompid { get; set; }
        public decimal Institemid { get; set; }
        public string Institemcode { get; set; }
        public long? Unitfloor { get; set; }
        public string Unitno { get; set; }
        public decimal? Uintsize { get; set; }
        public long? Unitrooms { get; set; }
        public string Unitscount { get; set; }
        public string Institemvcode { get; set; }
        public string Madatorename { get; set; }
        public string Madatoreyenname { get; set; }
        public long? Unitcount { get; set; }
        public decimal? Unitrentamount { get; set; }
    }
}
