using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Attachmentfeature
    {
        public Attachmentfeature()
        {
            Cminstitemattatchmentfeatures = new HashSet<Cminstitemattatchmentfeature>();
            Institemattatchmentfeatures = new HashSet<Institemattatchmentfeature>();
            Institemattatchmentfeaturesus = new HashSet<Institemattatchmentfeaturesu>();
            Salerentinstattatchmentfeatures = new HashSet<Salerentinstattatchmentfeature>();
        }

        public decimal Id { get; set; }
        public decimal? Attachmenttypesid { get; set; }
        public decimal? Featuretypesid { get; set; }

        public virtual Attachmenttype Attachmenttypes { get; set; }
        public virtual Featuretype Featuretypes { get; set; }
        public virtual ICollection<Cminstitemattatchmentfeature> Cminstitemattatchmentfeatures { get; set; }
        public virtual ICollection<Institemattatchmentfeature> Institemattatchmentfeatures { get; set; }
        public virtual ICollection<Institemattatchmentfeaturesu> Institemattatchmentfeaturesus { get; set; }
        public virtual ICollection<Salerentinstattatchmentfeature> Salerentinstattatchmentfeatures { get; set; }
    }
}
