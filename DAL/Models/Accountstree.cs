using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Accountstree
    {
        public Accountstree()
        {
            //InverseParent = new HashSet<Accountstree>();
        }
        [Key]
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public bool? Islastmainaccount { get; set; }
        public decimal? Relaytoid { get; set; }
        public decimal? Naturalid { get; set; }
        public DateTime? Openingdate { get; set; }
        public int? Currencyid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Dimensionoptionid { get; set; }
        public decimal? Acclevelsid { get; set; }
        public int? Parentid { get; set; }
        public string Code { get; set; }
        public bool? Isdetailedaccount { get; set; }

        [ForeignKey("Currencyid")]
        public virtual Currencym Currency { get; set; }
        [ForeignKey("Parentid")]
        public virtual Accountstree Parent { get; set; }
        //public virtual ICollection<Accountstree> InverseParent { get; set; }
    }
}
