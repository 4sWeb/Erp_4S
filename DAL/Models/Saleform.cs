using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleform
    {
        public Saleform()
        {
            Cancellationorwaivertrns = new HashSet<Cancellationorwaivertrn>();
            Convlegalaffairs = new HashSet<Convlegalaffair>();
            Financialcancellations = new HashSet<Financialcancellation>();
            SaleformAccepts = new HashSet<SaleformAccept>();
            Saleformapplevels = new HashSet<Saleformapplevel>();
            Saleformapprovals = new HashSet<Saleformapproval>();
            Saleformdeliverunits = new HashSet<Saleformdeliverunit>();
            Saleformdocattachments = new HashSet<Saleformdocattachment>();
            Saleforminsprograms = new HashSet<Saleforminsprogram>();
            Saleforminstalmentrules = new HashSet<Saleforminstalmentrule>();
            Saleforminstalmentsms = new HashSet<Saleforminstalmentsm>();
            Saleforminstpenaltyrules = new HashSet<Saleforminstpenaltyrule>();
            Saleformreports = new HashSet<Saleformreport>();
            Saleinsatlementsadddeducs = new HashSet<Saleinsatlementsadddeduc>();
            Saleinstalmentsms = new HashSet<Saleinstalmentsm>();
            Saleinstalmentsos = new HashSet<Saleinstalmentso>();
            Salerentcompositeitems = new HashSet<Salerentcompositeitem>();
            Salerentinstitems = new HashSet<Salerentinstitem>();
        }

        public decimal Id { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? Formstatustypes { get; set; }
        public string DocNo { get; set; }
        public decimal? FinanceGuardian { get; set; }
        public string Ownername { get; set; }
        public string Eownername { get; set; }
        public DateTime? Systemdate { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Itemactivitytype { get; set; }
        public decimal? Formtype { get; set; }
        public decimal? Instprogram { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Attachmentsvalue2 { get; set; }
        public decimal? Servicesvalue2 { get; set; }
        public decimal? Featuresvalue2 { get; set; }
        public DateTime? Contractsigndate { get; set; }
        public DateTime? HandoverDateIn { get; set; }
        public DateTime? HandoverDateExpected { get; set; }
        public DateTime? HandoverDateActual { get; set; }
        public decimal? Staff1 { get; set; }
        public decimal? Supervisor1 { get; set; }
        public decimal? Staff2 { get; set; }
        public decimal? Supervisor2 { get; set; }
        public decimal? Director { get; set; }
        public string IsReplacement { get; set; }
        public decimal? Orgsaleformid { get; set; }
        public decimal? Allowadjustinstallment { get; set; }
        public decimal? Valueofbenefits { get; set; }
        public decimal? Punich { get; set; }
        public decimal? NoOfInstalmentMonths { get; set; }
        public decimal? Receivingcontract { get; set; }
        public decimal? Deliverbymonth { get; set; }
        public bool? Formapproved { get; set; }
        public decimal? Campcode { get; set; }
        public string Rep2 { get; set; }
        public decimal? Campresource { get; set; }

        public virtual StoreAllsubcode Branch { get; set; }
        public virtual StoreAllsubcode CampcodeNavigation { get; set; }
        public virtual StoreAllsubcode CampresourceNavigation { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual StoreAllcode FinanceGuardianNavigation { get; set; }
        public virtual StoreAllsubcode FormstatustypesNavigation { get; set; }
        public virtual StoreAllsubcode FormtypeNavigation { get; set; }
        public virtual Instprogram InstprogramNavigation { get; set; }
        public virtual StoreAllsubcode ItemactivitytypeNavigation { get; set; }
        public virtual ICollection<Cancellationorwaivertrn> Cancellationorwaivertrns { get; set; }
        public virtual ICollection<Convlegalaffair> Convlegalaffairs { get; set; }
        public virtual ICollection<Financialcancellation> Financialcancellations { get; set; }
        public virtual ICollection<SaleformAccept> SaleformAccepts { get; set; }
        public virtual ICollection<Saleformapplevel> Saleformapplevels { get; set; }
        public virtual ICollection<Saleformapproval> Saleformapprovals { get; set; }
        public virtual ICollection<Saleformdeliverunit> Saleformdeliverunits { get; set; }
        public virtual ICollection<Saleformdocattachment> Saleformdocattachments { get; set; }
        public virtual ICollection<Saleforminsprogram> Saleforminsprograms { get; set; }
        public virtual ICollection<Saleforminstalmentrule> Saleforminstalmentrules { get; set; }
        public virtual ICollection<Saleforminstalmentsm> Saleforminstalmentsms { get; set; }
        public virtual ICollection<Saleforminstpenaltyrule> Saleforminstpenaltyrules { get; set; }
        public virtual ICollection<Saleformreport> Saleformreports { get; set; }
        public virtual ICollection<Saleinsatlementsadddeduc> Saleinsatlementsadddeducs { get; set; }
        public virtual ICollection<Saleinstalmentsm> Saleinstalmentsms { get; set; }
        public virtual ICollection<Saleinstalmentso> Saleinstalmentsos { get; set; }
        public virtual ICollection<Salerentcompositeitem> Salerentcompositeitems { get; set; }
        public virtual ICollection<Salerentinstitem> Salerentinstitems { get; set; }
    }
}
