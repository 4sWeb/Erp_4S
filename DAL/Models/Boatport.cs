using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Boatport
    {
        public Boatport()
        {
            StoreTrnsMArrivalports = new HashSet<StoreTrnsM>();
            StoreTrnsMShipboats = new HashSet<StoreTrnsM>();
            StoreTrnsMShipports = new HashSet<StoreTrnsM>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }

        public virtual ICollection<StoreTrnsM> StoreTrnsMArrivalports { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMShipboats { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMShipports { get; set; }
    }
}
