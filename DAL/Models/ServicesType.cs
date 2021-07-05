using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesType
    {
        public ServicesType()
        {
            Codelinkservaccs = new HashSet<Codelinkservacc>();
            ServicesHolds = new HashSet<ServicesHold>();
            ServicesInstitemServiceTypes = new HashSet<ServicesInstitemServiceType>();
            ServicesPrices = new HashSet<ServicesPrice>();
        }

        public decimal Servicesid { get; set; }
        public string Aservname { get; set; }
        public string Eservname { get; set; }
        public decimal? Servunit { get; set; }
        public string Servtype { get; set; }
        public decimal? Servcounter { get; set; }
        public string Servcode { get; set; }
        public string DependOnUnitArea { get; set; }
        public string IsInitial { get; set; }
        public string IsAnnualMintinance { get; set; }
        public decimal? MDelay { get; set; }
        public decimal? IsDeposit { get; set; }

        public virtual StoreUnit ServunitNavigation { get; set; }
        public virtual ICollection<Codelinkservacc> Codelinkservaccs { get; set; }
        public virtual ICollection<ServicesHold> ServicesHolds { get; set; }
        public virtual ICollection<ServicesInstitemServiceType> ServicesInstitemServiceTypes { get; set; }
        public virtual ICollection<ServicesPrice> ServicesPrices { get; set; }
    }
}
