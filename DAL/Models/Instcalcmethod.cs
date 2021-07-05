using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instcalcmethod
    {
        public Instcalcmethod()
        {
            Attachmenttypes = new HashSet<Attachmenttype>();
            Featuretypes = new HashSet<Featuretype>();
            Institemattatchmentfeatures = new HashSet<Institemattatchmentfeature>();
            Institemattatchments = new HashSet<Institemattatchment>();
            Institemattatchmentservices = new HashSet<Institemattatchmentservice>();
            Institemattatchmentservicesus = new HashSet<Institemattatchmentservicesu>();
            Institemattatchmentsus = new HashSet<Institemattatchmentsu>();
            Institemfeatures = new HashSet<Institemfeature>();
            Institemservices = new HashSet<Institemservice>();
            Salerentinstattatchmentfeatures = new HashSet<Salerentinstattatchmentfeature>();
            Salerentinstattatchmentservices = new HashSet<Salerentinstattatchmentservice>();
            Salerentinstitemattatchments = new HashSet<Salerentinstitemattatchment>();
            Salerentinstitemfeatures = new HashSet<Salerentinstitemfeature>();
            Salerentinstitemservices = new HashSet<Salerentinstitemservice>();
            Servicetypes = new HashSet<Servicetype>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Attachmenttype> Attachmenttypes { get; set; }
        public virtual ICollection<Featuretype> Featuretypes { get; set; }
        public virtual ICollection<Institemattatchmentfeature> Institemattatchmentfeatures { get; set; }
        public virtual ICollection<Institemattatchment> Institemattatchments { get; set; }
        public virtual ICollection<Institemattatchmentservice> Institemattatchmentservices { get; set; }
        public virtual ICollection<Institemattatchmentservicesu> Institemattatchmentservicesus { get; set; }
        public virtual ICollection<Institemattatchmentsu> Institemattatchmentsus { get; set; }
        public virtual ICollection<Institemfeature> Institemfeatures { get; set; }
        public virtual ICollection<Institemservice> Institemservices { get; set; }
        public virtual ICollection<Salerentinstattatchmentfeature> Salerentinstattatchmentfeatures { get; set; }
        public virtual ICollection<Salerentinstattatchmentservice> Salerentinstattatchmentservices { get; set; }
        public virtual ICollection<Salerentinstitemattatchment> Salerentinstitemattatchments { get; set; }
        public virtual ICollection<Salerentinstitemfeature> Salerentinstitemfeatures { get; set; }
        public virtual ICollection<Salerentinstitemservice> Salerentinstitemservices { get; set; }
        public virtual ICollection<Servicetype> Servicetypes { get; set; }
    }
}
