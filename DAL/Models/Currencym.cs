using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Currencym
    {
        public Currencym()
        {
            Accountingentries = new HashSet<Accountingentry>();
            Accounts = new HashSet<Account>();
            Accountstrees = new HashSet<Accountstree>();
            Checks = new HashSet<Check>();
            Cminstitemtempletes = new HashSet<Cminstitemtemplete>();
            Costcenters = new HashSet<Costcenter>();
            Currencyos = new HashSet<Currencyo>();
            Dimensionsdetails = new HashSet<Dimensionsdetail>();
            EvaluaPricePromationDetails = new HashSet<EvaluaPricePromationDetail>();
            EvaluationPricePromations = new HashSet<EvaluationPricePromation>();
            Financems = new HashSet<Financem>();
            Institems = new HashSet<Institem>();
            Journalentriesdetails = new HashSet<Journalentriesdetail>();
            Journalentriesmains = new HashSet<Journalentriesmain>();
            LgTransactionEdits = new HashSet<LgTransactionEdit>();
            LgTransactions = new HashSet<LgTransaction>();
            Rentforms = new HashSet<Rentform>();
            ReservedUnits = new HashSet<ReservedUnit>();
            Saleforms = new HashSet<Saleform>();
            StoreAllcodesBegins = new HashSet<StoreAllcodesBegin>();
            StoreTrnsLcs = new HashSet<StoreTrnsLc>();
            Usercurrencies = new HashSet<Usercurrency>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Shortname { get; set; }
        public string Isdefault { get; set; }
        public string AcurrUnit1 { get; set; }
        public string AcurrUnit2 { get; set; }
        public string AcurrUnit3 { get; set; }
        public string AcurrUnit4 { get; set; }
        public string AfracUnit1 { get; set; }
        public string AfracUnit2 { get; set; }
        public string AfracUnit3 { get; set; }
        public string AfracUnit4 { get; set; }
        public string EcurrUnit1 { get; set; }
        public string EcurrUnit2 { get; set; }
        public string EcurrUnit3 { get; set; }
        public string EcurrUnit4 { get; set; }
        public string EfracUnit1 { get; set; }
        public string EfracUnit2 { get; set; }
        public string EfracUnit3 { get; set; }
        public string EfracUnit4 { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<Accountingentry> Accountingentries { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Accountstree> Accountstrees { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Cminstitemtemplete> Cminstitemtempletes { get; set; }
        public virtual ICollection<Costcenter> Costcenters { get; set; }
        public virtual ICollection<Currencyo> Currencyos { get; set; }
        public virtual ICollection<Dimensionsdetail> Dimensionsdetails { get; set; }
        public virtual ICollection<EvaluaPricePromationDetail> EvaluaPricePromationDetails { get; set; }
        public virtual ICollection<EvaluationPricePromation> EvaluationPricePromations { get; set; }
        public virtual ICollection<Financem> Financems { get; set; }
        public virtual ICollection<Institem> Institems { get; set; }
        public virtual ICollection<Journalentriesdetail> Journalentriesdetails { get; set; }
        public virtual ICollection<Journalentriesmain> Journalentriesmains { get; set; }
        public virtual ICollection<LgTransactionEdit> LgTransactionEdits { get; set; }
        public virtual ICollection<LgTransaction> LgTransactions { get; set; }
        public virtual ICollection<Rentform> Rentforms { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnits { get; set; }
        public virtual ICollection<Saleform> Saleforms { get; set; }
        public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegins { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcs { get; set; }
        public virtual ICollection<Usercurrency> Usercurrencies { get; set; }
    }
}
