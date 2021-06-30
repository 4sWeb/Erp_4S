using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Dimensionlevels
    {
        public Dimensionlevels()
        {
            //Dimensionsdetails = new HashSet<Dimensionsdetails>();
        }

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Length { get; set; }
        public decimal? Levelno { get; set; }
        public int? Dimensionsid { get; set; }

        [ForeignKey("Dimensionsid")]
        public virtual Dimensions Dimensions { get; set; }
        //public virtual ICollection<Dimensionsdetails> Dimensionsdetails { get; set; }
    }
}
