using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cancellationorwaivertrn
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime? Trnsdate { get; set; }
        public string Fromcustomer { get; set; }
        public string Tocustomer { get; set; }
        public decimal? FinanceGuardianfrom { get; set; }
        public decimal? FinanceGuardianto { get; set; }
        public string Efromcustomer { get; set; }
        public string Etocustomer { get; set; }
        public decimal? Newinstalmentval { get; set; }
        public string Authorizationnum { get; set; }
        public string Authorizationname { get; set; }

        public virtual StoreAllcode FinanceGuardianfromNavigation { get; set; }
        public virtual StoreAllcode FinanceGuardiantoNavigation { get; set; }
        public virtual Saleform Saleform { get; set; }
    }
}
