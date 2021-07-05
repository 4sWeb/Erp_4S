using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemmaintypesproperty
    {
        public Institemmaintypesproperty()
        {
            Cminstitemlayoutdetails = new HashSet<Cminstitemlayoutdetail>();
            Cminstitemproperties = new HashSet<Cminstitemproperty>();
            Institemproperties = new HashSet<Institemproperty>();
            Salerentinstitemproperties = new HashSet<Salerentinstitemproperty>();
        }

        public decimal Id { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Subtypeid { get; set; }
        public string Datavalidationtype { get; set; }
        public decimal? Datasize { get; set; }

        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual MainType Subtype { get; set; }
        public virtual ICollection<Cminstitemlayoutdetail> Cminstitemlayoutdetails { get; set; }
        public virtual ICollection<Cminstitemproperty> Cminstitemproperties { get; set; }
        public virtual ICollection<Institemproperty> Institemproperties { get; set; }
        public virtual ICollection<Salerentinstitemproperty> Salerentinstitemproperties { get; set; }
    }
}
