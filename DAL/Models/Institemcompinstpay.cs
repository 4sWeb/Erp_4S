using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemcompinstpay
    {
        public Institemcompinstpay()
        {
            Institemchecks = new HashSet<Institemcheck>();
            RentformFinances = new HashSet<RentformFinance>();
        }

        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public string Installmentcode { get; set; }
        public DateTime? Installmentdate { get; set; }
        public decimal? Installmentvalue { get; set; }
        public decimal? Installmenttypeid { get; set; }
        public string Notes { get; set; }

        public virtual StoreAllsubcode Installmenttype { get; set; }
        public virtual Institem Institem { get; set; }
        public virtual ICollection<Institemcheck> Institemchecks { get; set; }
        public virtual ICollection<RentformFinance> RentformFinances { get; set; }
    }
}
