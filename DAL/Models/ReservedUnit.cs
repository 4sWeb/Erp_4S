using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ReservedUnit
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Compositeid { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? ReservedBy { get; set; }
        public decimal? AreservedFor { get; set; }
        public string EreservedFor { get; set; }
        public string Active { get; set; }
        public decimal? Userid { get; set; }
        public DateTime? Todate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Depositvalue { get; set; }
        public bool? Reservebydeposit { get; set; }
        public decimal? RegIdFromcrm { get; set; }
        public decimal? Campcode { get; set; }
        public decimal? Rep2 { get; set; }
        public decimal? Rep { get; set; }
        public decimal? Campresource { get; set; }
        public string Director { get; set; }
        public decimal? Instprogid { get; set; }

        public virtual StoreAllsubcode CampcodeNavigation { get; set; }
        public virtual StoreAllsubcode CampresourceNavigation { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Instprogram Instprog { get; set; }
        public virtual StoreAllcode Rep2Navigation { get; set; }
        public virtual staff RepNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
