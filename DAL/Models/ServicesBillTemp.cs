using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesBillTemp
    {
        public string UniqueId { get; set; }
        public DateTime? IndateTo { get; set; }
        public decimal? Flag { get; set; }
        public string LayoutName { get; set; }
        public string UnitCode { get; set; }
        public decimal? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAname { get; set; }
        public string CustomerAddress { get; set; }
        public decimal? UnitId { get; set; }
        public string Aservname { get; set; }
        public decimal? ServicesInstitemServTypeId { get; set; }
        public string IsDebtor { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Column { get; set; }
        public DateTime? ActualIndateTo { get; set; }
        public string Column1 { get; set; }
        public string Stagename { get; set; }
        public string FinanceRemark { get; set; }
        public decimal? Percname { get; set; }
    }
}
