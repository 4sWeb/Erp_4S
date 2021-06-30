using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreDepSpecs
    {
        public StoreDepSpecs()
        {
            //StoreDepSpecsDetails = new HashSet<StoreDepSpecsDetails>();
            //StoreTrnsDep = new HashSet<StoreTrnsDep>();
        }

        public decimal Groupno { get; set; }
        public int Trnscode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        [Key]
        public int StoreDepSpecsId { get; set; }
        public decimal? DepVal { get; set; }

        [ForeignKey("Trnscode")]
        public virtual StoreTrns TrnscodeNavigation { get; set; }
        //public virtual ICollection<StoreDepSpecsDetails> StoreDepSpecsDetails { get; set; }
        //public virtual ICollection<StoreTrnsDep> StoreTrnsDep { get; set; }
    }
}
