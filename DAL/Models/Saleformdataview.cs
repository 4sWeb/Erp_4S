using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformdataview
    {
        public decimal Id { get; set; }
        public string DocNo { get; set; }
        public decimal Instalmentid { get; set; }
        public string Instalmentname { get; set; }
        public string Instalmentename { get; set; }
        public DateTime? Indate { get; set; }
        public string Financeaname { get; set; }
        public string Financeename { get; set; }
        public string Financecode { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Val { get; set; }
        public decimal? Grossleft { get; set; }
        public decimal? Penaltyexemptionrate { get; set; }
        public decimal Punich { get; set; }
        public short? Overallserial { get; set; }
    }
}
