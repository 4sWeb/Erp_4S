using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FinanceAnlsCode
    {
        public FinanceAnlsCode()
        {
            FinanceAnlsCodesFactors = new HashSet<FinanceAnlsCodesFactor>();
        }

        public decimal FinanceAnlsCodesId { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public bool? AddToLc { get; set; }
        public bool? DistributOnQty { get; set; }
        public bool? HasItemFactor { get; set; }
        public decimal? Accountid { get; set; }
        public bool? Costeffect { get; set; }
        public bool? Invoiceeffect { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual ICollection<FinanceAnlsCodesFactor> FinanceAnlsCodesFactors { get; set; }
    }
}
