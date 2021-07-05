using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreInventoryM
    {
        public StoreInventoryM()
        {
            StoreInventoryOs = new HashSet<StoreInventoryO>();
        }

        public decimal Id { get; set; }
        public decimal? InventoryNum { get; set; }
        public DateTime? InventoryDate { get; set; }
        public decimal? StoreId { get; set; }
        public string Notes { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? Branchid { get; set; }

        public virtual StoreAllsubcode Branch { get; set; }
        public virtual Period Period { get; set; }
        public virtual StoreAllcode Store { get; set; }
        public virtual ICollection<StoreInventoryO> StoreInventoryOs { get; set; }
    }
}
