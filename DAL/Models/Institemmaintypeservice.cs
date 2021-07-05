using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemmaintypeservice
    {
        public Institemmaintypeservice()
        {
            Cminstitemservices = new HashSet<Cminstitemservice>();
            Institemservices = new HashSet<Institemservice>();
            Institemservicesus = new HashSet<Institemservicesu>();
            Salerentinstitemservices = new HashSet<Salerentinstitemservice>();
        }

        public decimal Id { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public decimal? ServiceTypeId { get; set; }

        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual Servicetype ServiceType { get; set; }
        public virtual ICollection<Cminstitemservice> Cminstitemservices { get; set; }
        public virtual ICollection<Institemservice> Institemservices { get; set; }
        public virtual ICollection<Institemservicesu> Institemservicesus { get; set; }
        public virtual ICollection<Salerentinstitemservice> Salerentinstitemservices { get; set; }
    }
}
