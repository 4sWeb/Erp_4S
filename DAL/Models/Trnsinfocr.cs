using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Trnsinfocr
    {
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public string Branch { get; set; }
        public decimal BranchId { get; set; }
        public string FromDistname { get; set; }
        public string FromDistFormname { get; set; }
        public decimal? FromDistFormid { get; set; }
        public string FromDistCodename { get; set; }
        public decimal? Fromcodetype { get; set; }
        public decimal? Fromcodeform { get; set; }
        public string Fromcode { get; set; }
        public decimal? Fromstoreallcodesid { get; set; }
        public string ToDistname { get; set; }
        public string ToDistFormname { get; set; }
        public decimal? ToDistFormid { get; set; }
        public string ToDistCodename { get; set; }
        public decimal? Tocodetype { get; set; }
        public decimal? Tocodeform { get; set; }
        public string Tocode { get; set; }
        public decimal? Tostoreallcodesid { get; set; }
        public string Rem { get; set; }
        public decimal? Total { get; set; }
        public decimal StoreTrnsMId { get; set; }
        public string TrnsName { get; set; }
        public DateTime? TrnsDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? Cargoexpected { get; set; }
        public DateTime? Cargoactually { get; set; }
        public DateTime? Portarrival { get; set; }
        public decimal? MainCostcenterid { get; set; }
        public bool? Cargopaper { get; set; }
        public decimal? Storedocnum { get; set; }
        public decimal? Period { get; set; }
        public decimal? Commited { get; set; }
        public byte Trnstype { get; set; }
        public bool? Reservation { get; set; }
    }
}
