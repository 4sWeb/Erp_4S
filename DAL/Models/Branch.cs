using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Branch
    {
        public string Code { get; set; }
        public string Descr { get; set; }
        public string Warehouse { get; set; }
        public string AddItems { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string BranchAddress { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public DateTime? Receivefromdate { get; set; }
        public DateTime? Receivetodate { get; set; }
        public string NameEn { get; set; }
        public string Dbserver { get; set; }
        public string Dbuser { get; set; }
        public string StrReceivefromdate { get; set; }
        public string StrReceivetodate { get; set; }
        public string LogoPath { get; set; }
        public decimal? Company { get; set; }
        public string LehaaCode { get; set; }
        public string LehaaLostCode { get; set; }
        public string LehaaBranchCode { get; set; }
        public string Transfersdepartment { get; set; }
        public string Branchdepartment { get; set; }
        public decimal? UploadingPrice { get; set; }
    }
}
