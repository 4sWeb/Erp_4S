using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreItemformsSpecs
    {
        public StoreItemformsSpecs()
        {
            //StoreItems = new HashSet<StoreItems>();
            //StoreTrns = new HashSet<StoreTrns>();
        }

        public byte PricingPolicy { get; set; }
        [Key]
        public int StoreItemfromsSpecsId { get; set; }
        public int? GroupfId { get; set; }
        public decimal? DecimalSystem { get; set; }
        public bool? Datevalidity { get; set; }
        public bool? Dateprod { get; set; }
        public bool? Serial { get; set; }
        public bool? Controlno { get; set; }
        public bool? Seriesno { get; set; }
        public bool? Lotno { get; set; }
        public bool? Place { get; set; }
        public bool? Datewarning { get; set; }
        public decimal? Warningtime { get; set; }
        public string Field1aname { get; set; }
        public string Field1ename { get; set; }
        public string Field2aname { get; set; }
        public string Field2ename { get; set; }
        public string Field3aname { get; set; }
        public string Field3ename { get; set; }
        public string Field4aname { get; set; }
        public string Field4ename { get; set; }
        public string Field5aname { get; set; }
        public string Field5ename { get; set; }
        public string Field6aname { get; set; }
        public string Field6ename { get; set; }
        public string Field7aname { get; set; }
        public string Field7ename { get; set; }
        public string Field8aname { get; set; }
        public string Field8ename { get; set; }
        public string Field9aname { get; set; }
        public string Field9ename { get; set; }
        public string Field10aname { get; set; }
        public string Field10ename { get; set; }
        public byte? Field1rank { get; set; }
        public byte? Field2rank { get; set; }
        public byte? Field3rank { get; set; }
        public byte? Field4rank { get; set; }
        public byte? Field5rank { get; set; }
        public byte? Field6rank { get; set; }
        public byte? Field7rank { get; set; }
        public byte? Field8rank { get; set; }
        public byte? Field9rank { get; set; }
        public byte? Field10rank { get; set; }

        [ForeignKey("GroupfId")]
        public virtual Groupf Groupf { get; set; }
        //public virtual ICollection<StoreItems> StoreItems { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrns { get; set; }
    }
}
