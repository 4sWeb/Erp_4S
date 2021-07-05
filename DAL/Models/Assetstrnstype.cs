using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Assetstrnstype
    {
        public Assetstrnstype()
        {
            Assetstranscations = new HashSet<Assetstranscation>();
        }

        public decimal Id { get; set; }
        public string Assettrnsnamear { get; set; }
        public string Assettrnsnameen { get; set; }

        public virtual ICollection<Assetstranscation> Assetstranscations { get; set; }
    }
}
