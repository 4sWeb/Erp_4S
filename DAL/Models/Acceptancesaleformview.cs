using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Acceptancesaleformview
    {
        public decimal Saleformid { get; set; }
        public string DocNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Branchaname { get; set; }
        public string Branchename { get; set; }
        public string Customername { get; set; }
        public string Customerename { get; set; }
        public string Statue { get; set; }
        public string Estatue { get; set; }
        public decimal? Formstatustypes { get; set; }
        public decimal? Currencyid { get; set; }
        public string Mandatorycode { get; set; }
        public string InstitemMainTypesName { get; set; }
        public string InstitemMainTypesEname { get; set; }
        public string Institemcode { get; set; }
    }
}
