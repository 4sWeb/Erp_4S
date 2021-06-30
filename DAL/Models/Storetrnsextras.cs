using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Storetrnsextras
    {
        public Storetrnsextras()
        {
            //Storemextras = new HashSet<Storemextras>();
        }

        public int Id { get; set; }
        public int? Transid { get; set; }
        public int? Extrasfieldid { get; set; }

        [ForeignKey("Extrasfieldid")]
        public virtual Extras Extrasfield { get; set; }
        [ForeignKey("Transid")]
        public virtual StoreTrns Trans { get; set; }
      //public virtual ICollection<Storemextras> Storemextras { get; set; } 
    }
}
