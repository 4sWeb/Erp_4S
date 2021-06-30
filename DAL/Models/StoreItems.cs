using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreItems
    {
        public StoreItems()
        {
            //AgridataItem = new HashSet<Agridata>();
            //AgridataPreviousitem = new HashSet<Agridata>();
            //Productformladetails = new HashSet<Productformladetails>();
            //Productstages = new HashSet<Productstages>();
            //StoreAllsubcodes = new HashSet<StoreAllsubcodes>();
            //StoreItemUnits = new HashSet<StoreItemUnits>();
            //StoreTrnsO = new HashSet<StoreTrnsO>();
            //StoreTrnsProducationformla = new HashSet<StoreTrnsProducationformla>();
        }

        public string ItemCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Saname { get; set; }
        public string Sename { get; set; }
        public decimal? IPurchPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? BranchPrice { get; set; }
        public decimal? DealPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        [Key]
        public int StoreItemsId { get; set; }
        public int? StoreItemfromsSpecsId { get; set; }
        public decimal? RetailPrice { get; set; }
        public bool? Isstoped { get; set; }
        public string Notes { get; set; }
        public string Notese { get; set; }
        public string Itembarcode { get; set; }

        [ForeignKey("StoreItemfromsSpecsId")]
        public virtual StoreItemformsSpecs StoreItemfromsSpecs { get; set; }
        //public virtual ICollection<Agridata> AgridataItem { get; set; }
        //public virtual ICollection<Agridata> AgridataPreviousitem { get; set; }
        //public virtual ICollection<Productformladetails> Productformladetails { get; set; }
        //public virtual ICollection<Productstages> Productstages { get; set; }
        //public virtual ICollection<StoreAllsubcodes> StoreAllsubcodes { get; set; }
        //public virtual ICollection<StoreItemUnits> StoreItemUnits { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsO { get; set; }
        //public virtual ICollection<StoreTrnsProducationformla> StoreTrnsProducationformla { get; set; }
    }
}
