﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesInstitemView
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
        public string StageCode { get; set; }
        public string StageName { get; set; }
        public decimal? MandatoryId { get; set; }
        public decimal? BenefitsValue { get; set; }
        public decimal OrderIdx { get; set; }
    }
}
