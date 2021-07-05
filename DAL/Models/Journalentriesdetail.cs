using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Journalentriesdetail
    {
        public Journalentriesdetail()
        {
            Journalentriesdimensions = new HashSet<Journalentriesdimension>();
        }

        public decimal Id { get; set; }
        public decimal Accounttreeid { get; set; }
        public decimal? Dimensiondetailsid { get; set; }
        public decimal Value { get; set; }
        public decimal? Naturalaccountid { get; set; }
        public string Entrydesc { get; set; }
        public decimal? Journalentrymainid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Currencyrate { get; set; }
        public decimal? Storeallcodesid { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual Dimensionsdetail Dimensiondetails { get; set; }
        public virtual Journalentriesmain Journalentrymain { get; set; }
        public virtual Naturalaccount Naturalaccount { get; set; }
        public virtual StoreAllcode Storeallcodes { get; set; }
        public virtual ICollection<Journalentriesdimension> Journalentriesdimensions { get; set; }
    }
}
