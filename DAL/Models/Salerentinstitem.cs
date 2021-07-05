using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Salerentinstitem
    {
        public Salerentinstitem()
        {
            Salerentinstattatchmentfeatures = new HashSet<Salerentinstattatchmentfeature>();
            Salerentinstattatchmentservices = new HashSet<Salerentinstattatchmentservice>();
            Salerentinstitemattatchments = new HashSet<Salerentinstitemattatchment>();
            Salerentinstitemfeatures = new HashSet<Salerentinstitemfeature>();
            Salerentinstitemproperties = new HashSet<Salerentinstitemproperty>();
            Salerentinstitemservices = new HashSet<Salerentinstitemservice>();
        }

        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string Institemcode { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Unitval3 { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Attachmentsvalue1 { get; set; }
        public decimal? Attachmentsvalue2 { get; set; }
        public decimal? Servicesvalue1 { get; set; }
        public decimal? Servicesvalue2 { get; set; }
        public decimal? Featuresvalue1 { get; set; }
        public decimal? Featuresvalue2 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public decimal? Rentval { get; set; }
        public string Rentvalperiod { get; set; }
        public string Mandatorycode { get; set; }
        public DateTime? HandoverDateInDate { get; set; }
        public DateTime? HandoverDateExpectedDate { get; set; }
        public DateTime? HandoverDateActualDate { get; set; }
        public decimal? Mandatoryid { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Layout { get; set; }
        public decimal? Currencyid { get; set; }

        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual Rentform Rentform { get; set; }
        public virtual Saleform Saleform { get; set; }
        public virtual ICollection<Salerentinstattatchmentfeature> Salerentinstattatchmentfeatures { get; set; }
        public virtual ICollection<Salerentinstattatchmentservice> Salerentinstattatchmentservices { get; set; }
        public virtual ICollection<Salerentinstitemattatchment> Salerentinstitemattatchments { get; set; }
        public virtual ICollection<Salerentinstitemfeature> Salerentinstitemfeatures { get; set; }
        public virtual ICollection<Salerentinstitemproperty> Salerentinstitemproperties { get; set; }
        public virtual ICollection<Salerentinstitemservice> Salerentinstitemservices { get; set; }
    }
}
