using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Agriprocess
    {
        public Agriprocess()
        {
            Agriages = new HashSet<Agriage>();
            StoreTrnsOs = new HashSet<StoreTrnsO>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public decimal? Typeid { get; set; }
        public string Processtype { get; set; }

        public virtual StoreAllcode Type { get; set; }
        public virtual ICollection<Agriage> Agriages { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
    }
}
