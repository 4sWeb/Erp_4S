using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Agridata
    {
        public Agridata()
        {
            //StoreTrnsM = new HashSet<StoreTrnsM>();
        }

        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Typeid { get; set; }
        public int? Itemid { get; set; }
        public int? Previousitemid { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public DateTime? Agridate { get; set; }
        public DateTime? Harvestdate { get; set; }
        public DateTime? Irritationdate { get; set; }
        public string Actualspace { get; set; }
        public string Agrispace { get; set; }
        public int? Dimensionid { get; set; }
        public int? Raiseid { get; set; }
        public int? Agriwayid { get; set; }
        public string Expectedqty { get; set; }
        public int? Agriorigin { get; set; }

        [ForeignKey("Agriorigin")]
        public virtual StoreAllsubcodes AgrioriginNavigation { get; set; }
        [ForeignKey("Agriwayid")]
        public virtual StoreAllsubcodes Agriway { get; set; }
        [ForeignKey("Dimensionid")]
        public virtual Dimensionsdetails Dimension { get; set; }
        [ForeignKey("Itemid")]
        public virtual StoreItems Item { get; set; }
        [ForeignKey("Previousitemid")]
        public virtual StoreItems Previousitem { get; set; }
        [ForeignKey("Raiseid")]
        public virtual StoreAllsubcodes Raise { get; set; }
        [ForeignKey("Typeid")]
        public virtual StoreAllcodes Type { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
    }
}
