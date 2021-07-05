using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsCreation
    {
        public decimal StoreTrnsCreatId { get; set; }
        public string StoreTrnsCreatTrnsmcode { get; set; }
        public string StoreTrnsCreatTrnsmpcode { get; set; }
        public bool? StoreTrnsCreatReverse { get; set; }
        public bool? StoreTrnsCreatSamedep { get; set; }
        public bool? StoreTrnsCreatSametrns { get; set; }
        public int? StoreTrnsCreatQunatity { get; set; }
        public bool? StoreTrnsCreatMaterials { get; set; }
        public decimal? StoreTrnsCreatFromid { get; set; }
        public decimal? StoreTrnsCreatToid { get; set; }
        public bool? StoreTrnsCreatReserv { get; set; }
    }
}
