using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Agriprocess
    {
        public Agriprocess()
        {
            //Agriage = new HashSet<Agriage>();
            //StoreTrnsOAgriage = new HashSet<StoreTrnsO>();
            //StoreTrnsOProcess = new HashSet<StoreTrnsO>();
        }

        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public int? Typeid { get; set; }
        public string Processtype { get; set; }

        [ForeignKey("Typeid")]
        public virtual StoreAllcodes Type { get; set; }
        //public virtual ICollection<Agriage> Agriage { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsOAgriage { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsOProcess { get; set; }
    }
}
