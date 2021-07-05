using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Asset
    {
        public Asset()
        {
            Assetstranscations = new HashSet<Assetstranscation>();
            DepreciationcalcmFromassetNavigations = new HashSet<Depreciationcalcm>();
            DepreciationcalcmToassetNavigations = new HashSet<Depreciationcalcm>();
            Depreciationcalcos = new HashSet<Depreciationcalco>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Currbranchid { get; set; }
        public decimal? Firstbranchid { get; set; }
        public decimal? Currdistinationid { get; set; }
        public decimal? Firstdistinationid { get; set; }
        public decimal? Employeeid { get; set; }
        public decimal? Jobid { get; set; }
        public decimal? Rentalvalue { get; set; }
        public bool? Isassetmantained { get; set; }
        public decimal? Docno { get; set; }
        public decimal? Dimentiondetailsid { get; set; }
        public decimal? Accountid { get; set; }
        public DateTime? Purchasedate { get; set; }
        public decimal? Purchasevalue { get; set; }
        public string Purchasenum { get; set; }
        public string Itemnumber { get; set; }
        public DateTime? Operationdate { get; set; }
        public decimal? Docvalue { get; set; }
        public decimal? Junkvalue { get; set; }
        public decimal? Depreciationid { get; set; }
        public decimal? Depreciationvalue { get; set; }
        public DateTime? Lastdepreciationdate { get; set; }
        public decimal? Defalutdepreciationratio { get; set; }
        public string Notes { get; set; }
        public bool? Istransportasset { get; set; }
        public decimal? Transporttypeid { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? Firstpurchasevalue { get; set; }
        public decimal? Depreciationcomplexvalue { get; set; }
        public decimal? Lastdocvalue { get; set; }
        public decimal? Lastdepreciationvalue { get; set; }
        public decimal? Additionvalue { get; set; }
        public decimal? Benifitvalue { get; set; }
        public decimal? Assetaccountid { get; set; }
        public decimal? Depreciationcomplexaccountid { get; set; }
        public decimal? Depreciationinstallmentaccount { get; set; }
        public decimal? Depreciationtotalvalue { get; set; }
        public bool? Isoldasset { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual Accountstree Assetaccount { get; set; }
        public virtual StoreAllsubcode Currbranch { get; set; }
        public virtual StoreAllcode Currdistination { get; set; }
        public virtual Depreciation Depreciation { get; set; }
        public virtual Accountstree Depreciationcomplexaccount { get; set; }
        public virtual Accountstree DepreciationinstallmentaccountNavigation { get; set; }
        public virtual Dimensionsdetail Dimentiondetails { get; set; }
        public virtual StoreAllsubcode Firstbranch { get; set; }
        public virtual StoreAllcode Firstdistination { get; set; }
        public virtual Period Period { get; set; }
        public virtual ICollection<Assetstranscation> Assetstranscations { get; set; }
        public virtual ICollection<Depreciationcalcm> DepreciationcalcmFromassetNavigations { get; set; }
        public virtual ICollection<Depreciationcalcm> DepreciationcalcmToassetNavigations { get; set; }
        public virtual ICollection<Depreciationcalco> Depreciationcalcos { get; set; }
    }
}
