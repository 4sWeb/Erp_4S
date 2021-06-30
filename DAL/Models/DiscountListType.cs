using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class DiscountListType
    {
        public DiscountListType()
        {
            //DiscountItemM = new HashSet<DiscountItemM>();
        }

        [Key]
        public int DiscountListId { get; set; }
        public string DiscountCode { get; set; }
        public string Descripation { get; set; }
        public string Engdesc { get; set; }

       //public virtual ICollection<DiscountItemM> DiscountItemM { get; set; }
    }
}
