using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Assetsgroup
    {
        public Assetsgroup()
        {
            DepreciationcalcmFromgroupassetNavigations = new HashSet<Depreciationcalcm>();
            DepreciationcalcmTogroupassetNavigations = new HashSet<Depreciationcalcm>();
            InverseParent = new HashSet<Assetsgroup>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Depreciationid { get; set; }
        public decimal? Assetslevels { get; set; }
        public decimal? Parentid { get; set; }
        public decimal? Assetaccountid { get; set; }
        public decimal? Depreciationcomplexaccountid { get; set; }
        public decimal? Depreciationinstallmentaccount { get; set; }

        public virtual Accountstree Assetaccount { get; set; }
        public virtual Assetslevel AssetslevelsNavigation { get; set; }
        public virtual Depreciation Depreciation { get; set; }
        public virtual Accountstree Depreciationcomplexaccount { get; set; }
        public virtual Accountstree DepreciationinstallmentaccountNavigation { get; set; }
        public virtual Assetsgroup Parent { get; set; }
        public virtual ICollection<Depreciationcalcm> DepreciationcalcmFromgroupassetNavigations { get; set; }
        public virtual ICollection<Depreciationcalcm> DepreciationcalcmTogroupassetNavigations { get; set; }
        public virtual ICollection<Assetsgroup> InverseParent { get; set; }
    }
}
