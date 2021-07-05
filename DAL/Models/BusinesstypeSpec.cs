using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class BusinesstypeSpec
    {
        public decimal Id { get; set; }
        public decimal? Businessid { get; set; }
        public decimal? Mandatorytype { get; set; }
        public decimal? GroupfId { get; set; }
        public decimal? Formid { get; set; }

        public virtual StoreAllsubcode Business { get; set; }
        public virtual MainType MandatorytypeNavigation { get; set; }
    }
}
