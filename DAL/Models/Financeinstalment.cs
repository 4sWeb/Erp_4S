using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financeinstalment
    {
        public decimal Id { get; set; }
        public decimal? Trnsid { get; set; }
        public decimal? Checkid { get; set; }
        public string Paytype { get; set; }
        public decimal? Instalmentid { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Earlydiscount { get; set; }
        public decimal? Fixedcostval { get; set; }
        public decimal? Penaltyval { get; set; }
        public decimal? Rentinstalmentid { get; set; }
        public decimal? Reschedualid { get; set; }

        public virtual Check Check { get; set; }
        public virtual Saleinstalmentso Instalment { get; set; }
        public virtual Rentinstalmentso Rentinstalment { get; set; }
        public virtual Financem Trns { get; set; }
    }
}
