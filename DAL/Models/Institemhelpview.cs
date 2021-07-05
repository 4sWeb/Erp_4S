using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemhelpview
    {
        public decimal Id { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal Institemid { get; set; }
        public string Institemcode { get; set; }
        public string Mandatorycode { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Attachvalue { get; set; }
        public decimal? Servicevalue { get; set; }
        public decimal? Featurevalue { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string InstitemMainTypesName { get; set; }
        public string InstitemMainTypesEname { get; set; }
        public decimal GroupfId { get; set; }
        public decimal? Layout { get; set; }
        public decimal? MaxClevel { get; set; }
    }
}
