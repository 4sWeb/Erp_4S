using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Analyticalnumber
    {
        public Analyticalnumber()
        {
            Accountingentries = new HashSet<Accountingentry>();
        }

        public decimal Analyticalnumberid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Accountingentry> Accountingentries { get; set; }
    }
}
