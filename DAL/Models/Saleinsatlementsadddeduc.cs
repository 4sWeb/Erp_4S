using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleinsatlementsadddeduc
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Saleinstalmenttypesid { get; set; }
        public decimal? Saleadddeducreasonsid { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Indate { get; set; }
        public string Valuetype { get; set; }

        public virtual Saleadddeducreason Saleadddeducreasons { get; set; }
        public virtual Saleform Saleform { get; set; }
        public virtual Saleinstalmentso Saleinstalmenttypes { get; set; }
    }
}
