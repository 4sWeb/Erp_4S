using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institem
    {
        public Institem()
        {
            Institemattatchmentfeatures = new HashSet<Institemattatchmentfeature>();
            Institemattatchments = new HashSet<Institemattatchment>();
            Institemattatchmentservices = new HashSet<Institemattatchmentservice>();
            Institemcompinstpays = new HashSet<Institemcompinstpay>();
            Institemcomps = new HashSet<Institemcomp>();
            Institemproperties = new HashSet<Institemproperty>();
            Institemservices = new HashSet<Institemservice>();
        }

        public decimal Id { get; set; }
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
        public decimal? Layout { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Owner { get; set; }
        public decimal? Buyer { get; set; }
        public DateTime? Buydate { get; set; }
        public decimal? Paymethod { get; set; }
        public decimal? Buyermethod { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }

        public virtual StoreAllsubcode BuyerNavigation { get; set; }
        public virtual StoreAllsubcode BuyermethodNavigation { get; set; }
        public virtual Compositeinstitem Composite { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual StoreAllcode Mandatory { get; set; }
        public virtual StoreAllsubcode OwnerNavigation { get; set; }
        public virtual StoreAllsubcode PaymethodNavigation { get; set; }
        public virtual ICollection<Institemattatchmentfeature> Institemattatchmentfeatures { get; set; }
        public virtual ICollection<Institemattatchment> Institemattatchments { get; set; }
        public virtual ICollection<Institemattatchmentservice> Institemattatchmentservices { get; set; }
        public virtual ICollection<Institemcompinstpay> Institemcompinstpays { get; set; }
        public virtual ICollection<Institemcomp> Institemcomps { get; set; }
        public virtual ICollection<Institemproperty> Institemproperties { get; set; }
        public virtual ICollection<Institemservice> Institemservices { get; set; }
    }
}
