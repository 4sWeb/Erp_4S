using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentform
    {
        public Rentform()
        {
            Institemcompdetails = new HashSet<Institemcompdetail>();
            Rentformdocattachments = new HashSet<Rentformdocattachment>();
            Rentformrenews = new HashSet<Rentformrenew>();
            Rentinsatlementsadddeducs = new HashSet<Rentinsatlementsadddeduc>();
            Rentinstalmentsms = new HashSet<Rentinstalmentsm>();
            Rentinstalmentsos = new HashSet<Rentinstalmentso>();
            Salerentcompositeitems = new HashSet<Salerentcompositeitem>();
            Salerentinstitems = new HashSet<Salerentinstitem>();
        }

        public decimal Id { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? Formstatustypes { get; set; }
        public string DocNo { get; set; }
        public decimal? Financeguardian { get; set; }
        public string Ownername { get; set; }
        public string Eownername { get; set; }
        public DateTime? Systemdate { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? Formstartdate { get; set; }
        public DateTime? Formenddate { get; set; }
        public DateTime? Submitdate { get; set; }
        public DateTime? Actualenddate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Renttype { get; set; }
        public decimal? Itemactivitytype { get; set; }
        public decimal? Staff1 { get; set; }
        public decimal? Supervisor1 { get; set; }
        public decimal? Staff2 { get; set; }
        public decimal? Supervisor2 { get; set; }
        public decimal? Director { get; set; }
        public decimal? Taxvalue { get; set; }
        public decimal? Periodid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public bool? Cancelrent { get; set; }
        public DateTime? Canceldate { get; set; }
        public string Cancelreason { get; set; }

        public virtual StoreAllsubcode Branch { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual StoreAllcode FinanceguardianNavigation { get; set; }
        public virtual StoreAllsubcode FormstatustypesNavigation { get; set; }
        public virtual StoreAllsubcode ItemactivitytypeNavigation { get; set; }
        public virtual Period Period { get; set; }
        public virtual ICollection<Institemcompdetail> Institemcompdetails { get; set; }
        public virtual ICollection<Rentformdocattachment> Rentformdocattachments { get; set; }
        public virtual ICollection<Rentformrenew> Rentformrenews { get; set; }
        public virtual ICollection<Rentinsatlementsadddeduc> Rentinsatlementsadddeducs { get; set; }
        public virtual ICollection<Rentinstalmentsm> Rentinstalmentsms { get; set; }
        public virtual ICollection<Rentinstalmentso> Rentinstalmentsos { get; set; }
        public virtual ICollection<Salerentcompositeitem> Salerentcompositeitems { get; set; }
        public virtual ICollection<Salerentinstitem> Salerentinstitems { get; set; }
    }
}
