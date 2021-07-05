using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institem4crm
    {
        public decimal? Institemid { get; set; }
        public string Institemcode { get; set; }
        public string Mandatorycode { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Quantity1 { get; set; }
        public string PartCodeName1 { get; set; }
        public string PartCode1 { get; set; }
        public string PartCodeName2 { get; set; }
        public string PartCode2 { get; set; }
        public string InstitemMainTypesName { get; set; }
        public string Layout { get; set; }
        public string CompanyCode { get; set; }
        public string SchemaName { get; set; }
        public string CompanyName { get; set; }
        public decimal? RegIdFromcrm { get; set; }
    }
}
