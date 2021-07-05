using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DelayedInstalmentPayment
    {
        public decimal Id { get; set; }
        public string DocNo { get; set; }
        public decimal? FinanceGuardian { get; set; }
        public decimal? Staff1 { get; set; }
        public decimal? Staff2 { get; set; }
        public decimal? Institemid { get; set; }
        public string Institemcode { get; set; }
        public decimal? Mandatoryid { get; set; }
        public string Mandatorycode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Adds { get; set; }
        public decimal? Deducs { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Delay { get; set; }
        public string Tableflag { get; set; }
        public decimal? Instalmentownerid { get; set; }
        public decimal? Instalmentpartsid { get; set; }
        public short? Overallserial { get; set; }
        public string Serialname { get; set; }
        public string Instalmentname { get; set; }
        public string Serialename { get; set; }
        public string Instalmentename { get; set; }
        public decimal? Instalmentbenfitvalue { get; set; }
        public decimal? Instalmentvalueonly { get; set; }
        public decimal Instalmentid { get; set; }
        public decimal? Payed { get; set; }
        public decimal? PayedPenalty { get; set; }
        public decimal? PayedFixedcost { get; set; }
        public string PartCode1 { get; set; }
        public string PartCodeName1 { get; set; }
        public string PartCodeEname1 { get; set; }
        public string ApartName1 { get; set; }
        public string EpartName1 { get; set; }
        public string PartCode22 { get; set; }
        public string PartCodeName22 { get; set; }
        public string PartCodeEname22 { get; set; }
        public string ApartName22 { get; set; }
        public string EpartName22 { get; set; }
        public string PartCode3 { get; set; }
        public string PartCodeName3 { get; set; }
        public string PartCodeEname3 { get; set; }
        public string ApartName3 { get; set; }
        public string EpartName3 { get; set; }
        public string PartCode4 { get; set; }
        public string PartCodeName4 { get; set; }
        public string PartCodeEname4 { get; set; }
        public string ApartName4 { get; set; }
        public string EpartName4 { get; set; }
        public string Custename { get; set; }
        public string Custaname { get; set; }
        public string Staffename { get; set; }
        public string Staffaname { get; set; }
        public string Staffename2 { get; set; }
        public string Staffaname2 { get; set; }
    }
}
