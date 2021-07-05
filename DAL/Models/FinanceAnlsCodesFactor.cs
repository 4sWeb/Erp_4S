using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FinanceAnlsCodesFactor
    {
        public decimal Id { get; set; }
        public decimal? FinanceAnlsCodesId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Factor { get; set; }

        public virtual FinanceAnlsCode FinanceAnlsCodes { get; set; }
        public virtual StoreItem StoreItems { get; set; }
    }
}
