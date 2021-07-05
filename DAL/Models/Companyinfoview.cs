using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Companyinfoview
    {
        public decimal Copmid { get; set; }
        public string Copmname { get; set; }
        public string Copmaddress { get; set; }
        public decimal? CompanyRecordTrading { get; set; }
        public string CompanyLogo { get; set; }
        public decimal? Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal? Idnum { get; set; }
        public decimal? Companyinformationid { get; set; }
        public decimal? Isactive { get; set; }
        public string Companynametaxes { get; set; }
        public string Companyno { get; set; }
    }
}
