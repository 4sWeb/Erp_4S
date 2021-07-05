using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstitemHelp1
    {
        public decimal Id { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal Institemid { get; set; }
        public string Institemcode { get; set; }
        public string Mandatorycode { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Attachmentsvalue1 { get; set; }
        public decimal? Servicesvalue1 { get; set; }
        public decimal? Featuresvalue1 { get; set; }
        public string Acurrency { get; set; }
        public string Ecurrency { get; set; }
        public string InstitemMainTypesName { get; set; }
        public string InstitemMainTypesEname { get; set; }
        public decimal? BusinesstypeId { get; set; }
        public string PartCode { get; set; }
        public string PartCodeName { get; set; }
        public string PartCodeEname { get; set; }
        public byte? Clevel { get; set; }
        public decimal PartId { get; set; }
        public decimal? MaxClevel { get; set; }
        public decimal GroupfId { get; set; }
        public string ApartName { get; set; }
        public string EpartName { get; set; }
        public decimal? Layout { get; set; }
    }
}
