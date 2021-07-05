using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesPrice
    {
        public decimal Id { get; set; }
        public decimal? ServicesTypeId { get; set; }
        public decimal? Layout { get; set; }
        public decimal? PartId { get; set; }
        public decimal? Price { get; set; }
        public string PartCode { get; set; }
        public decimal? PartType { get; set; }

        public virtual StoreAllsubcode LayoutNavigation { get; set; }
        public virtual StoreAllsubcode Part { get; set; }
        public virtual ServicesType ServicesType { get; set; }
    }
}
