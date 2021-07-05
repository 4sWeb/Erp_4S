using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financespecdetail
    {
        public string Useorder { get; set; }
        public decimal? Orderspecid { get; set; }
        public string Gldistribution { get; set; }
        public string Personsdistribution { get; set; }
        public string Printfdist { get; set; }
        public string Descfdist { get; set; }
        public string Printtdist { get; set; }
        public string Desctdist { get; set; }
        public string Printgldist { get; set; }
        public string Printinventdist { get; set; }
        public string Signature1 { get; set; }
        public string Signature1name { get; set; }
        public string Signature2 { get; set; }
        public string Signature2name { get; set; }
        public string Signature3 { get; set; }
        public string Signature3name { get; set; }
        public string Transport { get; set; }
        public string Polices { get; set; }
        public string Driversconciliation { get; set; }
        public string Descfdiste { get; set; }
        public string Desctdiste { get; set; }
        public string Instalments { get; set; }
        public string Reportheader { get; set; }
        public string Reportfooter { get; set; }
        public decimal Id { get; set; }
        public decimal? Finacespectranscode { get; set; }

        public virtual Financespec FinacespectranscodeNavigation { get; set; }
    }
}
