using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Services4initialRequest
    {
        public decimal UnitId { get; set; }
        public string UnitCode { get; set; }
        public decimal? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAname { get; set; }
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
        public decimal? InitialRequest { get; set; }
        public DateTime? IndateTo { get; set; }
        public DateTime? IndateFrom { get; set; }
        public decimal? RequestmId { get; set; }
        public decimal? ServicesFinanceId { get; set; }
        public decimal? FinanceFval { get; set; }
        public decimal? PaymentRequestsId { get; set; }
        public decimal? Requestm2Id { get; set; }
        public string IsDebtor { get; set; }
        public string ProjectCode { get; set; }
        public string Project { get; set; }
        public string Stagecode { get; set; }
        public string Stag { get; set; }
        public decimal OrderIdx { get; set; }
        public string BuildCode { get; set; }
        public string Build { get; set; }
        public string Unitcode1 { get; set; }
        public string FloorCode { get; set; }
        public string Floor { get; set; }
    }
}
