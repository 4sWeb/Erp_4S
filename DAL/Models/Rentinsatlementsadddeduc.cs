using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentinsatlementsadddeduc
    {
        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Rentinstalmenttypesid { get; set; }
        public decimal? Rentadddeducreasonsid { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Indate { get; set; }

        public virtual Rentform Rentform { get; set; }
    }
}
