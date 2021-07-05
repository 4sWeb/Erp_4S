using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentformrenew
    {
        public Rentformrenew()
        {
            Institemcompdetails = new HashSet<Institemcompdetail>();
            Rentformrenewdetails = new HashSet<Rentformrenewdetail>();
        }

        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public bool? Isrenew { get; set; }
        public DateTime? Entrydate { get; set; }

        public virtual Rentform Rentform { get; set; }
        public virtual ICollection<Institemcompdetail> Institemcompdetails { get; set; }
        public virtual ICollection<Rentformrenewdetail> Rentformrenewdetails { get; set; }
    }
}
