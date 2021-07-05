using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Getrentformdataview
    {
        public decimal Saleformid { get; set; }
        public string DocNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Branchaname { get; set; }
        public string Branchename { get; set; }
        public string Customername { get; set; }
        public string Customerename { get; set; }
        public decimal? Currencyid { get; set; }
    }
}
