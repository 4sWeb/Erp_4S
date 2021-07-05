using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class User
    {
        public User()
        {
            AcceptInFinancetrns = new HashSet<AcceptInFinancetrn>();
            AcceptInTrns = new HashSet<AcceptInTrn>();
            AcceptInTrnsTemps = new HashSet<AcceptInTrnsTemp>();
            AcceptInsaleforms = new HashSet<AcceptInsaleform>();
            Branch1s = new HashSet<Branch1>();
            Conditionsbooklets = new HashSet<Conditionsbooklet>();
            Dependencytreereports = new HashSet<Dependencytreereport>();
            FinancetrnsUserAccepts = new HashSet<FinancetrnsUserAccept>();
            Progprivileges = new HashSet<Progprivilege>();
            ReservedUnits = new HashSet<ReservedUnit>();
            SaleformAccepts = new HashSet<SaleformAccept>();
            Saleformapplevels = new HashSet<Saleformapplevel>();
            Saleformapprovals = new HashSet<Saleformapproval>();
            Securities = new HashSet<Security>();
            StoreAllcodes = new HashSet<StoreAllcode>();
            TrnsUserAccepts = new HashSet<TrnsUserAccept>();
            Usercurrencies = new HashSet<Usercurrency>();
            Userinstitems = new HashSet<Userinstitem>();
            Userperiods = new HashSet<Userperiod>();
            Userreports = new HashSet<Userreport>();
            UsersRoles = new HashSet<UsersRole>();
            UsersStoreAllcodes = new HashSet<UsersStoreAllcode>();
            Userstrans = new HashSet<Userstran>();
            staff = new HashSet<staff>();
        }

        public decimal Userid { get; set; }
        public string Usercode { get; set; }
        public string Username { get; set; }
        public string Userename { get; set; }
        public string Userpassword { get; set; }
        public string Positionapps { get; set; }
        public decimal? Active { get; set; }
        public DateTime? Createdate { get; set; }
        public decimal? UsergroupId { get; set; }
        public decimal? Projectno { get; set; }
        public decimal? Privilegeid { get; set; }
        public string Salt { get; set; }
        public string Uname { get; set; }

        public virtual Usergroup Usergroup { get; set; }
        public virtual ICollection<AcceptInFinancetrn> AcceptInFinancetrns { get; set; }
        public virtual ICollection<AcceptInTrn> AcceptInTrns { get; set; }
        public virtual ICollection<AcceptInTrnsTemp> AcceptInTrnsTemps { get; set; }
        public virtual ICollection<AcceptInsaleform> AcceptInsaleforms { get; set; }
        public virtual ICollection<Branch1> Branch1s { get; set; }
        public virtual ICollection<Conditionsbooklet> Conditionsbooklets { get; set; }
        public virtual ICollection<Dependencytreereport> Dependencytreereports { get; set; }
        public virtual ICollection<FinancetrnsUserAccept> FinancetrnsUserAccepts { get; set; }
        public virtual ICollection<Progprivilege> Progprivileges { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnits { get; set; }
        public virtual ICollection<SaleformAccept> SaleformAccepts { get; set; }
        public virtual ICollection<Saleformapplevel> Saleformapplevels { get; set; }
        public virtual ICollection<Saleformapproval> Saleformapprovals { get; set; }
        public virtual ICollection<Security> Securities { get; set; }
        public virtual ICollection<StoreAllcode> StoreAllcodes { get; set; }
        public virtual ICollection<TrnsUserAccept> TrnsUserAccepts { get; set; }
        public virtual ICollection<Usercurrency> Usercurrencies { get; set; }
        public virtual ICollection<Userinstitem> Userinstitems { get; set; }
        public virtual ICollection<Userperiod> Userperiods { get; set; }
        public virtual ICollection<Userreport> Userreports { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
        public virtual ICollection<UsersStoreAllcode> UsersStoreAllcodes { get; set; }
        public virtual ICollection<Userstran> Userstrans { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
