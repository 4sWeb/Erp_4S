using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Bankingfacility
    {
        public decimal Id { get; set; }
        public decimal? Bankid { get; set; }
        public DateTime? Faciltiesdate { get; set; }
        public decimal? Facilitieslength { get; set; }
        public string Facilitiestype { get; set; }
        public decimal? Facilitiestotallength { get; set; }
        public string Facilitiestotaltype { get; set; }
        public decimal? Facilitiesvalue { get; set; }
        public decimal? Currencyid { get; set; }

        public virtual StoreAllcode Bank { get; set; }
    }
}
