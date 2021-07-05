using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemmaintypefeature
    {
        public Institemmaintypefeature()
        {
            Cminstitemfeatures = new HashSet<Cminstitemfeature>();
            Institemfeatures = new HashSet<Institemfeature>();
            Institemfeaturesus = new HashSet<Institemfeaturesu>();
            Salerentinstitemfeatures = new HashSet<Salerentinstitemfeature>();
        }

        public decimal Id { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public decimal? FeatureTypeId { get; set; }

        public virtual Featuretype FeatureType { get; set; }
        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual ICollection<Cminstitemfeature> Cminstitemfeatures { get; set; }
        public virtual ICollection<Institemfeature> Institemfeatures { get; set; }
        public virtual ICollection<Institemfeaturesu> Institemfeaturesus { get; set; }
        public virtual ICollection<Salerentinstitemfeature> Salerentinstitemfeatures { get; set; }
    }
}
