using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dimensionsdetail
    {
        public Dimensionsdetail()
        {
            Agridata = new HashSet<Agridatum>();
            Assets = new HashSet<Asset>();
            CustomerDimensionsdetails = new HashSet<CustomerDimensionsdetail>();
            Estimatedvalsdets = new HashSet<Estimatedvalsdet>();
            Institemcomps = new HashSet<Institemcomp>();
            InverseParent = new HashSet<Dimensionsdetail>();
            Journalentriesdetails = new HashSet<Journalentriesdetail>();
            Journalentriesdimensions = new HashSet<Journalentriesdimension>();
            MultydistDimensions = new HashSet<MultydistDimension>();
            PriceListCustomerOs = new HashSet<PriceListCustomerO>();
            StoreTrnsoDimendetailsTemps = new HashSet<StoreTrnsoDimendetailsTemp>();
            StoreTrnsoDimensionsdetails = new HashSet<StoreTrnsoDimensionsdetail>();
        }

        public decimal Id { get; set; }
        public decimal? Dimensionsid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Code { get; set; }
        public bool? Islastmaindimensions { get; set; }
        public bool? Isdetailed { get; set; }
        public decimal? Parentid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Dimensionlevelsid { get; set; }
        public string Parentcode { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual Dimensionlevel Dimensionlevels { get; set; }
        public virtual Dimension Dimensions { get; set; }
        public virtual Dimensionsdetail Parent { get; set; }
        public virtual ICollection<Agridatum> Agridata { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<CustomerDimensionsdetail> CustomerDimensionsdetails { get; set; }
        public virtual ICollection<Estimatedvalsdet> Estimatedvalsdets { get; set; }
        public virtual ICollection<Institemcomp> Institemcomps { get; set; }
        public virtual ICollection<Dimensionsdetail> InverseParent { get; set; }
        public virtual ICollection<Journalentriesdetail> Journalentriesdetails { get; set; }
        public virtual ICollection<Journalentriesdimension> Journalentriesdimensions { get; set; }
        public virtual ICollection<MultydistDimension> MultydistDimensions { get; set; }
        public virtual ICollection<PriceListCustomerO> PriceListCustomerOs { get; set; }
        public virtual ICollection<StoreTrnsoDimendetailsTemp> StoreTrnsoDimendetailsTemps { get; set; }
        public virtual ICollection<StoreTrnsoDimensionsdetail> StoreTrnsoDimensionsdetails { get; set; }
    }
}
