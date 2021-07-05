using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitembuildinglayer
    {
        public Cminstitembuildinglayer()
        {
            Cminstitemlayoutlayers = new HashSet<Cminstitemlayoutlayer>();
        }

        public decimal Id { get; set; }
        public decimal? Businesstypeid { get; set; }
        public decimal? Mandatoryfieldid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public DateTime? Creationdate { get; set; }

        public virtual StoreAllsubcode Businesstype { get; set; }
        public virtual StoreAllcode Mandatoryfield { get; set; }
        public virtual ICollection<Cminstitemlayoutlayer> Cminstitemlayoutlayers { get; set; }
    }
}
