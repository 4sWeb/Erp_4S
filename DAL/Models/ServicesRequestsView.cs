using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesRequestsView
    {
        public decimal Oid { get; set; }
        public decimal UnitId { get; set; }
        public string UnitCode { get; set; }
        public decimal? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAname { get; set; }
        public string Aservname { get; set; }
        public string CustomerAddress { get; set; }
        public decimal? UnitSpace { get; set; }
        public decimal? GardenSpace { get; set; }
        public decimal? InstitemValue { get; set; }
        public decimal? Layout { get; set; }
        public string LayoutName { get; set; }
        public decimal? DepositMaintenanceValue { get; set; }
        public decimal? DepositMaintenanceRatio { get; set; }
        public DateTime? DepositMaintenanceDate { get; set; }
        public DateTime? HandoverDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public string MandatoryCode { get; set; }
        public decimal? MandatoryId { get; set; }
        public decimal RequestmId { get; set; }
        public DateTime? InDate { get; set; }
        public decimal Servicesid { get; set; }
        public decimal? Total { get; set; }
        public decimal? Benefits { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Fvalforservice { get; set; }
        public string RequirdValue { get; set; }
    }
}
