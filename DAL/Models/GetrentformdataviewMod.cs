using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GetrentformdataviewMod
    {
        public decimal Saleformid { get; set; }
        public string DocNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Branchaname { get; set; }
        public string Branchename { get; set; }
        public decimal Branchid { get; set; }
        public string Customername { get; set; }
        public string Customerename { get; set; }
        public string Customercode { get; set; }
        public decimal Customerid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Remainvalue { get; set; }
    }
}
