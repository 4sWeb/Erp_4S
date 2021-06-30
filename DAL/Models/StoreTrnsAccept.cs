using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsAccept
    {
        public StoreTrnsAccept()
        {
            //AcceptInTrns = new HashSet<AcceptInTrns>();
        }
        [Key]
        public int AcceptId { get; set; }
        public decimal AcceptSerial { get; set; }
        public string AcceptName { get; set; }
        public int TrnsCode { get; set; }

        [ForeignKey("TrnsCode")]
        public virtual StoreTrns TrnsCodeNavigation { get; set; }
        //public virtual ICollection<AcceptInTrns> AcceptInTrns { get; set; }
    }
}
