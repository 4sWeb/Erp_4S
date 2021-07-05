using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Account
    {
        public Account()
        {
            Accountingentrydetails = new HashSet<Accountingentrydetail>();
        }

        public decimal Accountid { get; set; }
        public decimal? Sepcid { get; set; }
        public decimal? Parentid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Accountnatureid { get; set; }
        public DateTime? Datecreated { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Finalmiagrationid { get; set; }
        public decimal? Linkcostcenter { get; set; }
        public decimal? Intialbalancedebit { get; set; }
        public decimal? Intialbalancecredit { get; set; }
        public decimal? Levelnumber { get; set; }

        public virtual Accountnature Accountnature { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Finalmiagrationtype Finalmiagration { get; set; }
        public virtual Generalspec Sepc { get; set; }
        public virtual ICollection<Accountingentrydetail> Accountingentrydetails { get; set; }
    }
}
