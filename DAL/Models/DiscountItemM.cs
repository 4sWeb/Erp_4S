using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class DiscountItemM
    {
        public DiscountItemM()
        {
            //StoreTrnsM = new HashSet<StoreTrnsM>();
        }
        [Key]
        public int Itemchangeid { get; set; }
        public string Itemchangcode { get; set; }
        public string Itemchangeremark { get; set; }
        public decimal GroupfId { get; set; }
        public int DiscountTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("DiscountTypeId")]
        public virtual DiscountListType DiscountType { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
    }
}
