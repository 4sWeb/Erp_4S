using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Agriage
    {
        public Agriage()
        {
            //StoreTrnsO = new HashSet<StoreTrnsO>();
        }

        [Key]
        public int Id { get; set; }
        public int? Typeid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public int? Agriprocessid { get; set; }

        [ForeignKey("Agriprocessid")]
        public virtual Agriprocess Agriprocess { get; set; }
        [ForeignKey("Typeid")]
        public virtual StoreAllcodes Type { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsO { get; set; }
    }
}
