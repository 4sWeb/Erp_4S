using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Agrifarm
    {
        public Agrifarm()
        {
         //   StoreTrnsO = new HashSet<StoreTrnsO>();
        }
        [Key]
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Aname { get; set; }
        public string Code { get; set; }

        //public virtual ICollection<StoreTrnsO> StoreTrnsO { get; set; }
    }
}
