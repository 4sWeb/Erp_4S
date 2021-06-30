using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Boatport
    {
        public Boatport()
        {
            //StoreTrnsMArrivalport = new HashSet<StoreTrnsM>();
            //StoreTrnsMShipboat = new HashSet<StoreTrnsM>();
            //StoreTrnsMShipport = new HashSet<StoreTrnsM>();
        }

        [Key]
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }

        //public virtual ICollection<StoreTrnsM> StoreTrnsMArrivalport { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMShipboat { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMShipport { get; set; }
    }
}
