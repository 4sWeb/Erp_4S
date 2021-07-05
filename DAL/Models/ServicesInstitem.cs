using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesInstitem
    {
        public ServicesInstitem()
        {
            ServicesDeposits = new HashSet<ServicesDeposit>();
            ServicesHolds = new HashSet<ServicesHold>();
            ServicesPaymentRequestsms = new HashSet<ServicesPaymentRequestsm>();
        }

        public decimal Id { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string Institemcode { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? GardenSpace { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Layout { get; set; }
        public decimal? DepositMaintenanceValue { get; set; }
        public decimal? DepositBenefitsRetio { get; set; }
        public DateTime? HandoverDateActual { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? CustStoreAllcodesIdoriginal { get; set; }
        public decimal? CustStoreAllcodesIdnew { get; set; }
        public string Mandatorycode { get; set; }
        public decimal? Mandatoryid { get; set; }
        public decimal? InstitemmaintypesId1 { get; set; }
        public DateTime? DepositBenefitsDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public decimal OrderIdx { get; set; }
        public DateTime? Salesdate { get; set; }

        public virtual StoreAllcode CustStoreAllcodesIdnewNavigation { get; set; }
        public virtual Institemmaintype InstitemMainTypes { get; set; }
        public virtual Institemmaintype InstitemmaintypesId1Navigation { get; set; }
        public virtual StoreAllsubcode LayoutNavigation { get; set; }
        public virtual StoreAllcode Mandatory { get; set; }
        public virtual ICollection<ServicesDeposit> ServicesDeposits { get; set; }
        public virtual ICollection<ServicesHold> ServicesHolds { get; set; }
        public virtual ICollection<ServicesPaymentRequestsm> ServicesPaymentRequestsms { get; set; }
    }
}
