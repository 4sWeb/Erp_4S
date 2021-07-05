using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Selectcheck
    {
        public decimal? Id { get; set; }
        public string Checkno { get; set; }
        public decimal? Branch { get; set; }
        public decimal? CD { get; set; }
        public decimal? Checkserial { get; set; }
        public decimal? Period { get; set; }
        public decimal? Checktype { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Duedate { get; set; }
        public string Beneficiary { get; set; }
        public string Bankname { get; set; }
        public decimal? Debtorid { get; set; }
        public decimal? Financemid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public decimal? Vendorid { get; set; }
        public decimal? Valuetrns { get; set; }
        public decimal? Valuelocal { get; set; }
        public decimal? Fdistid { get; set; }
        public string Debtorname { get; set; }
        public string Debtorename { get; set; }
        public string Fromname { get; set; }
        public string Fromename { get; set; }
        public string Checktypename { get; set; }
        public string Checktypeename { get; set; }
        public decimal? Trnscode { get; set; }
        public string Curraname { get; set; }
        public string Currename { get; set; }
    }
}
