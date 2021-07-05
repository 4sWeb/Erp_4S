using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Simplesaleformview
    {
        public decimal Saleformid { get; set; }
        public decimal? Formstatustypes { get; set; }
        public decimal? Customerid { get; set; }
        public string Customername { get; set; }
        public string Customerename { get; set; }
        public string Staff1 { get; set; }
        public decimal Staff1id { get; set; }
        public string Staff2 { get; set; }
        public decimal Staff2id { get; set; }
        public string DocNo { get; set; }
        public string Layout { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string Institemcode { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Branchid { get; set; }
        public string Mandatorycode { get; set; }
        public string InstitemMainTypesName { get; set; }
        public string InstitemMainTypesEname { get; set; }
        public string PartCode1 { get; set; }
        public string PartCodeName1 { get; set; }
        public string PartCodeEname1 { get; set; }
        public string PartCodeName2 { get; set; }
        public string PartCode2 { get; set; }
        public string PartCodeEname2 { get; set; }
        public string PartCodeName3 { get; set; }
        public string PartCode3 { get; set; }
        public string PartCodeEname3 { get; set; }
        public string PartCodeName4 { get; set; }
        public string PartCode4 { get; set; }
        public string PartCodeEname4 { get; set; }
    }
}
