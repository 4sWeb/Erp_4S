using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Currencyo
    {
        public Currencyo()
        {
            StoreTrnsM = new HashSet<StoreTrnsM>();
        }
        public DateTime? Indate { get; set; }
        public decimal? Rate { get; set; }
        public decimal Id { get; set; }
        public decimal? Currmid { get; set; }
        public virtual Currencym Currm { get; set; }
        public ICollection< StoreTrnsM> StoreTrnsM { get; set; }

    }
}
