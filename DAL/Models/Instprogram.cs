using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instprogram
    {
        public Instprogram()
        {
            Cminstitemattatchments = new HashSet<Cminstitemattatchment>();
            Cminstitemfeatures = new HashSet<Cminstitemfeature>();
            Cminstitemservices = new HashSet<Cminstitemservice>();
            InstalmentsMs = new HashSet<InstalmentsM>();
            ReservedUnits = new HashSet<ReservedUnit>();
            Saleforminsprograms = new HashSet<Saleforminsprogram>();
            Saleforms = new HashSet<Saleform>();
            Saleinstalmentsos = new HashSet<Saleinstalmentso>();
            StoretrnsmInstalmentos = new HashSet<StoretrnsmInstalmento>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public byte? NoOfInstalmentYears { get; set; }
        public byte? NoOfInstalments { get; set; }
        public string Insttype { get; set; }
        public decimal? Totalinstdetails { get; set; }

        public virtual ICollection<Cminstitemattatchment> Cminstitemattatchments { get; set; }
        public virtual ICollection<Cminstitemfeature> Cminstitemfeatures { get; set; }
        public virtual ICollection<Cminstitemservice> Cminstitemservices { get; set; }
        public virtual ICollection<InstalmentsM> InstalmentsMs { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnits { get; set; }
        public virtual ICollection<Saleforminsprogram> Saleforminsprograms { get; set; }
        public virtual ICollection<Saleform> Saleforms { get; set; }
        public virtual ICollection<Saleinstalmentso> Saleinstalmentsos { get; set; }
        public virtual ICollection<StoretrnsmInstalmento> StoretrnsmInstalmentos { get; set; }
    }
}
