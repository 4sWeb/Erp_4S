using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Attachmentservice
    {
        public Attachmentservice()
        {
            Cminstitemattatchmentservices = new HashSet<Cminstitemattatchmentservice>();
            Institemattatchmentservices = new HashSet<Institemattatchmentservice>();
            Institemattatchmentservicesus = new HashSet<Institemattatchmentservicesu>();
            Salerentinstattatchmentservices = new HashSet<Salerentinstattatchmentservice>();
        }

        public decimal Id { get; set; }
        public decimal? Attachmenttypesid { get; set; }
        public decimal? Servicetypeid { get; set; }

        public virtual Attachmenttype Attachmenttypes { get; set; }
        public virtual Servicetype Servicetype { get; set; }
        public virtual ICollection<Cminstitemattatchmentservice> Cminstitemattatchmentservices { get; set; }
        public virtual ICollection<Institemattatchmentservice> Institemattatchmentservices { get; set; }
        public virtual ICollection<Institemattatchmentservicesu> Institemattatchmentservicesus { get; set; }
        public virtual ICollection<Salerentinstattatchmentservice> Salerentinstattatchmentservices { get; set; }
    }
}
