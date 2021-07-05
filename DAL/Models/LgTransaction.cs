using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgTransaction
    {
        public LgTransaction()
        {
            LgFinances = new HashSet<LgFinance>();
            LgTransactionEdits = new HashSet<LgTransactionEdit>();
        }

        public decimal Id { get; set; }
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
        public DateTime? CreateDate { get; set; }
        public string IsCancel { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime? EditDate { get; set; }
        public decimal? Branch { get; set; }
        public string IsClose { get; set; }
        public DateTime? CloseDate { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual LgCategory LgCat { get; set; }
        public virtual LgStatus LgStatus { get; set; }
        public virtual LgType LgTypes { get; set; }
        public virtual StoreAllcode StoreAllcodes { get; set; }
        public virtual ICollection<LgFinance> LgFinances { get; set; }
        public virtual ICollection<LgTransactionEdit> LgTransactionEdits { get; set; }
    }
}
