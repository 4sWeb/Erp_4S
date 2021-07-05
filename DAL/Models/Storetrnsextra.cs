using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsextra
    {
        public Storetrnsextra()
        {
            Storemextras = new HashSet<Storemextra>();
        }

        public decimal Id { get; set; }
        public decimal? Transid { get; set; }
        public decimal? Extrasfieldid { get; set; }

        public virtual Extra Extrasfield { get; set; }
        public virtual StoreTrn Trans { get; set; }
        public virtual ICollection<Storemextra> Storemextras { get; set; }
    }
}
