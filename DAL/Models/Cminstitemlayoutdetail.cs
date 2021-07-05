using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemlayoutdetail
    {
        public decimal Id { get; set; }
        public decimal? Layoutid { get; set; }
        public decimal? Institempropertiesid { get; set; }
        public decimal? Allsubid { get; set; }
        public string Data { get; set; }

        public virtual StoreAllsubcode Allsub { get; set; }
        public virtual Institemmaintypesproperty Institemproperties { get; set; }
    }
}
