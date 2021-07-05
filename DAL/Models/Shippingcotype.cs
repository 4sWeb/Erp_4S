using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Shippingcotype
    {
        public Shippingcotype()
        {
            StoreTrnsMClearancecos = new HashSet<StoreTrnsM>();
            StoreTrnsMShipcos = new HashSet<StoreTrnsM>();
            StoreTrnsMShiptrns = new HashSet<StoreTrnsM>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Companycode { get; set; }
        public string Companytype { get; set; }

        public virtual ICollection<StoreTrnsM> StoreTrnsMClearancecos { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMShipcos { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMShiptrns { get; set; }
    }
}
