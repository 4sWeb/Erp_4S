using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Multydistgrouptype
    {
        public decimal? Id { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? FinanceAnlsCodesId { get; set; }
        public decimal? Financemid { get; set; }
        public string Accountstreecode { get; set; }
        public string Accountstreename { get; set; }
        public string FtName { get; set; }
        public string Notes { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string ExpName { get; set; }
        public decimal? Hasaccount { get; set; }
        public decimal? Hasdimention { get; set; }
        public decimal? Hasdists { get; set; }
        public decimal? Hasexpensses { get; set; }
        public decimal Trnscode { get; set; }
        public string Financename { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal? Tdistid { get; set; }
        public string Fdistname { get; set; }
        public string Tdistname { get; set; }
        public decimal? Ftypeid { get; set; }
        public decimal? Ttypeid { get; set; }
        public DateTime? Trnsdate { get; set; }
        public string Dimansionaname { get; set; }
        public string Dimansionename { get; set; }
        public decimal? Dimansionid { get; set; }
    }
}
