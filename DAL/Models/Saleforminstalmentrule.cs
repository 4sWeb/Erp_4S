using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleforminstalmentrule
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Businessid { get; set; }
        public string ApplyTo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? ProfitRatio { get; set; }
        public string AffectReserve { get; set; }
        public string AffectContract { get; set; }
        public string AffectOthers { get; set; }
        public string AffectEnd { get; set; }
        public byte? MaxYears { get; set; }
        public byte? DefaultYears { get; set; }
        public decimal? MinRatioReserve { get; set; }
        public decimal? MinRatioContrcact { get; set; }
        public decimal? MinRatioEnd { get; set; }
        public string Instalmentrulescode { get; set; }
        public string Instalmentrulesaname { get; set; }
        public string Instalmentrulesename { get; set; }
        public decimal? Earlypayment { get; set; }
        public decimal? Waivervalue { get; set; }
        public string Waivervalueorratio { get; set; }
        public decimal? Cancelvalue { get; set; }
        public string Cancelvalueorratio { get; set; }
        public decimal? Waivervalueafcontract { get; set; }
        public string Waivervalueorratioafcontract { get; set; }
        public decimal? Cancelvalueafcontract { get; set; }
        public string Cancelvalueorratioafcontract { get; set; }

        public virtual Saleform Saleform { get; set; }
    }
}
