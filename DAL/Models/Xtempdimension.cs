using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Xtempdimension
    {
        public string Id { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Docnumber { get; set; }
        public string Entynumber { get; set; }
        public string Entrydesc { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Journalcodename { get; set; }
        public string Journalcodeename { get; set; }
        public string Accountname { get; set; }
        public string Accountcode { get; set; }
        public string Curencyname { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Totaldebitbefore { get; set; }
        public decimal? Totalcreditbefore { get; set; }
        public decimal? Flag { get; set; }
        public decimal? Naturalid { get; set; }
        public string Entydesc { get; set; }
        public decimal? Dimensiondetailsid { get; set; }
    }
}
