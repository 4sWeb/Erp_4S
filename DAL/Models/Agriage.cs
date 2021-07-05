using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Agriage
    {
        public Agriage()
        {
            StoreTrnsOs = new HashSet<StoreTrnsO>();
        }

        public decimal Id { get; set; }
        public decimal? Typeid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public decimal? Agriprocessid { get; set; }

        public virtual Agriprocess Agriprocess { get; set; }
        public virtual StoreAllcode Type { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
    }
}
