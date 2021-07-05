using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeallcodesview
    {
        public decimal StoreAllcodesId { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Form { get; set; }
        public string Formname { get; set; }
        public string Formename { get; set; }
        public decimal GroupfId { get; set; }
        public decimal Type { get; set; }
        public string Typename { get; set; }
        public string Typeename { get; set; }
        public decimal CashBeginDebit { get; set; }
        public decimal CashBeginCredit { get; set; }
        public decimal CheckBeginDebit { get; set; }
        public decimal CheckBeginCredit { get; set; }
    }
}
