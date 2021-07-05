using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Accountstree
    {
        public Accountstree()
        {
            AssetAccounts = new HashSet<Asset>();
            AssetAssetaccounts = new HashSet<Asset>();
            AssetDepreciationcomplexaccounts = new HashSet<Asset>();
            AssetDepreciationinstallmentaccountNavigations = new HashSet<Asset>();
            AssetsgroupAssetaccounts = new HashSet<Assetsgroup>();
            AssetsgroupDepreciationcomplexaccounts = new HashSet<Assetsgroup>();
            AssetsgroupDepreciationinstallmentaccountNavigations = new HashSet<Assetsgroup>();
            AssetstranscationTrnsaccount2Navigations = new HashSet<Assetstranscation>();
            AssetstranscationTrnsaccountNavigations = new HashSet<Assetstranscation>();
            Codelinkpartdetails = new HashSet<Codelinkpartdetail>();
            Codelinkservaccs = new HashSet<Codelinkservacc>();
            Codeslinkdetails = new HashSet<Codeslinkdetail>();
            Codeslinkitemdetails = new HashSet<Codeslinkitemdetail>();
            Codeslinks = new HashSet<Codeslink>();
            Estimatedvals = new HashSet<Estimatedval>();
            FinanceAnlsCodes = new HashSet<FinanceAnlsCode>();
            InverseParent = new HashSet<Accountstree>();
            Journalcodesaccs = new HashSet<Journalcodesacc>();
            LgDescriptionsOs = new HashSet<LgDescriptionsO>();
            StageCostaccs = new HashSet<StageCostacc>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public bool? Islastmainaccount { get; set; }
        public decimal? Relaytoid { get; set; }
        public decimal? Naturalid { get; set; }
        public DateTime? Openingdate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Dimensionoptionid { get; set; }
        public decimal? Acclevelsid { get; set; }
        public decimal? Parentid { get; set; }
        public string Code { get; set; }
        public bool? Isdetailedaccount { get; set; }

        public virtual Acclevel Acclevels { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Dimensionoption Dimensionoption { get; set; }
        public virtual Accountnature Natural { get; set; }
        public virtual Accountstree Parent { get; set; }
        public virtual Relayto Relayto { get; set; }
        public virtual ICollection<Asset> AssetAccounts { get; set; }
        public virtual ICollection<Asset> AssetAssetaccounts { get; set; }
        public virtual ICollection<Asset> AssetDepreciationcomplexaccounts { get; set; }
        public virtual ICollection<Asset> AssetDepreciationinstallmentaccountNavigations { get; set; }
        public virtual ICollection<Assetsgroup> AssetsgroupAssetaccounts { get; set; }
        public virtual ICollection<Assetsgroup> AssetsgroupDepreciationcomplexaccounts { get; set; }
        public virtual ICollection<Assetsgroup> AssetsgroupDepreciationinstallmentaccountNavigations { get; set; }
        public virtual ICollection<Assetstranscation> AssetstranscationTrnsaccount2Navigations { get; set; }
        public virtual ICollection<Assetstranscation> AssetstranscationTrnsaccountNavigations { get; set; }
        public virtual ICollection<Codelinkpartdetail> Codelinkpartdetails { get; set; }
        public virtual ICollection<Codelinkservacc> Codelinkservaccs { get; set; }
        public virtual ICollection<Codeslinkdetail> Codeslinkdetails { get; set; }
        public virtual ICollection<Codeslinkitemdetail> Codeslinkitemdetails { get; set; }
        public virtual ICollection<Codeslink> Codeslinks { get; set; }
        public virtual ICollection<Estimatedval> Estimatedvals { get; set; }
        public virtual ICollection<FinanceAnlsCode> FinanceAnlsCodes { get; set; }
        public virtual ICollection<Accountstree> InverseParent { get; set; }
        public virtual ICollection<Journalcodesacc> Journalcodesaccs { get; set; }
        public virtual ICollection<LgDescriptionsO> LgDescriptionsOs { get; set; }
        public virtual ICollection<StageCostacc> StageCostaccs { get; set; }
    }
}
