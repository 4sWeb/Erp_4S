using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ExpensessTrnsView
    {
        public decimal StoreTrnsMId { get; set; }
        public string Expensescode { get; set; }
        public string Expensesname { get; set; }
        public decimal? Foreignval { get; set; }
        public decimal? Localval { get; set; }
        public decimal? Curr { get; set; }
        public decimal? Rate { get; set; }
    }
}
