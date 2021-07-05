using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Sumfinstalmentswreschedual
    {
        public decimal? Checkid { get; set; }
        public decimal? Instalmentid { get; set; }
        public string DocNo { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Penaltyval { get; set; }
        public decimal? Fixedcostval { get; set; }
        public decimal? Earlydiscount { get; set; }
        public string Instalmentname { get; set; }
        public string Instalmentename { get; set; }
        public DateTime? Indate { get; set; }
        public string Formtype { get; set; }
    }
}
