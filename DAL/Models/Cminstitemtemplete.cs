using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemtemplete
    {
        public decimal Id { get; set; }
        public decimal? Templetedesignid { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
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
        public decimal? Unitcount { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Layout { get; set; }
        public decimal? Currencyid { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual StoreAllcode Mandatory { get; set; }
        public virtual Cminstitemtempletedesign Templetedesign { get; set; }
    }
}
