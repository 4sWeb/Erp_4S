using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Extras
    {
        public Extras()
        {
           //Storetrnsextras = new HashSet<Storetrnsextras>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Nameen { get; set; }
        public string Note { get; set; }
        public decimal? Extdttxt { get; set; }

        //public virtual ICollection<Storetrnsextras> Storetrnsextras { get; set; }
    }
}
