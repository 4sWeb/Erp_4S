using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreDepSpecsDetails
    {
        public int GroupId { get; set; }
        public decimal Depslot { get; set; }
        public int DepOnTrnsCode { get; set; }
        public decimal? Getitems { get; set; }
        public decimal? Depsign { get; set; }
        public decimal? GetFrom { get; set; }
        public decimal? GetTo { get; set; }
        [Key]
        public int StoreDepSpecsDetailsId { get; set; }
        public decimal? CollectItem { get; set; }
        public decimal? DepType { get; set; }
        public decimal? Onlyonedep { get; set; }
        public decimal? DepMust { get; set; }
        public decimal? Adjustdeponprice { get; set; }
        public decimal? Payrevers { get; set; }
        public decimal? DepList { get; set; }
        public decimal? FromFilter { get; set; }
        public decimal? ToFilter { get; set; }
        public decimal? Sumqtyonitems { get; set; }
        public decimal? DepShipinfo { get; set; }
        public decimal? DepMaincostcent { get; set; }
        public decimal? Getdepocostcent { get; set; }
        public decimal? Depmainacc { get; set; }
        public decimal? Getdepoacc { get; set; }
        public decimal? Getdesc { get; set; }
        public decimal? DepPricType { get; set; }
        public decimal? Depquantities { get; set; }
        public decimal? AdditemOutDep { get; set; }
        public decimal? Autodep { get; set; }
        public decimal? Autodepcode { get; set; }
        public decimal? Salesrep { get; set; }
        public decimal? Ctax { get; set; }
        public decimal? Ctaxdisc { get; set; }
        public decimal? Stax { get; set; }
        public decimal? Depqtyratio { get; set; }
        public decimal? Getcost { get; set; }
        public decimal? Deponpricecost { get; set; }
        public decimal? Hasextras { get; set; }
        //[ForeignKey("DepOnTrnsCode")]
        //public virtual StoreTrns DepOnTrnsCodeNavigation { get; set; }
        //[ForeignKey("GroupId")]
        //public virtual StoreDepSpecs Group { get; set; }
    }
}
