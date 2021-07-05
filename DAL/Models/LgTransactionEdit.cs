using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgTransactionEdit
    {
        public decimal Id { get; set; }
        public decimal? LgTransactionId { get; set; }
        public decimal? DocNo { get; set; }
        public decimal? LgCatId { get; set; }
        public decimal? BankId { get; set; }
        public string BankDocNo { get; set; }
        public decimal? LgTypesId { get; set; }
        public decimal? LgStatusId { get; set; }
        public DateTime? IndateFrom { get; set; }
        public DateTime? IndateTo { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? CurrencyId { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? LocalAmount { get; set; }
        public decimal? MarginRatio { get; set; }
        public decimal? BankRatio { get; set; }
        public string Note { get; set; }
        public DateTime? EditDate { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual LgCategory LgCat { get; set; }
        public virtual LgStatus LgStatus { get; set; }
        public virtual LgTransaction LgTransaction { get; set; }
        public virtual LgType LgTypes { get; set; }
        public virtual StoreAllcode StoreAllcodes { get; set; }
    }
}
