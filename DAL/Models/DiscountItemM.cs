using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DiscountItemM
    {
        public DiscountItemM()
        {
            ItemDiscountOs = new HashSet<ItemDiscountO>();
            StoreTrnsMTemps = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMs = new HashSet<StoreTrnsM>();
        }

        public decimal Itemchangeid { get; set; }
        public string Itemchangcode { get; set; }
        public string Itemchangeremark { get; set; }
        public decimal GroupfId { get; set; }
        public decimal DiscountTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual DiscountListType DiscountType { get; set; }
        public virtual ICollection<ItemDiscountO> ItemDiscountOs { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTemps { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMs { get; set; }
    }
}
