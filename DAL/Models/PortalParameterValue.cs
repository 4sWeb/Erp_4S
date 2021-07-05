using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PortalParameterValue
    {
        public decimal Id { get; set; }
        public string FromRoom { get; set; }
        public string ToRoom { get; set; }
        public string FromItem { get; set; }
        public string ToItem { get; set; }
        public string FromCostCenter { get; set; }
        public string ToCostCenter { get; set; }
        public string FromDestination { get; set; }
        public string ToDestination { get; set; }
        public int? ContractNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
