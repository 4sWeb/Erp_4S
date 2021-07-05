using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VServicesdatesmonthly
    {
        public string CustomerAname { get; set; }
        public string CustomerCode { get; set; }
        public string UnitCode { get; set; }
        public string LayoutName { get; set; }
        public string Stagename { get; set; }
        public decimal? Benefits { get; set; }
        public DateTime? CalculationDate { get; set; }
        public DateTime? DepositMaintenanceDate { get; set; }
        public decimal? Servicevalue { get; set; }
        public decimal? Fvalforservice { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? HandoverDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Aservname { get; set; }
        public decimal UnitId { get; set; }
    }
}
