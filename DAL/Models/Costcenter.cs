using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Costcenter
    {
        public Costcenter()
        {
            Accountingentrydetails = new HashSet<Accountingentrydetail>();
        }

        public decimal Costcenterid { get; set; }
        public decimal? Specid { get; set; }
        public decimal? Parentid { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Workhours { get; set; }
        public decimal? Productionrate { get; set; }
        public DateTime? Datecreated { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Initialbalancedebit { get; set; }
        public decimal? Initialbalancecreadit { get; set; }
        public decimal? Workhourcost { get; set; }
        public decimal? Productionunitcost { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual Generalspec Spec { get; set; }
        public virtual ICollection<Accountingentrydetail> Accountingentrydetails { get; set; }
    }
}
