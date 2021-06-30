using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Dimensionsdetails
    {
        public Dimensionsdetails()
        {
            //Agridata = new HashSet<Agridata>();
            //InverseParent = new HashSet<Dimensionsdetails>();
            //StoreTrnsoDimensionsdetails = new HashSet<StoreTrnsoDimensionsdetails>();
        }

        public int Id { get; set; }
        public int? Dimensionsid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Code { get; set; }
        public bool? Islastmaindimensions { get; set; }
        public bool? Isdetailed { get; set; }
        public int? Parentid { get; set; }
        public int? Currencyid { get; set; }
        public decimal? Rate { get; set; }
        public int? Dimensionlevelsid { get; set; }
        public string Parentcode { get; set; }

        [ForeignKey("Currencyid")]
        public virtual Currencym Currency { get; set; }
        [ForeignKey("Dimensionlevelsid")]
        public virtual Dimensionlevels Dimensionlevels { get; set; }
        [ForeignKey("Dimensionsid")]
        public virtual Dimensions Dimensions { get; set; }
        [ForeignKey("Parentid")]
        public virtual Dimensionsdetails Parent { get; set; }
        //public virtual ICollection<Agridata> Agridata { get; set; }
        //public virtual ICollection<Dimensionsdetails> InverseParent { get; set; }
        //public virtual ICollection<StoreTrnsoDimensionsdetails> StoreTrnsoDimensionsdetails { get; set; }
    }
}
