using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Shippingcotypes
    {
        public Shippingcotypes()
        {
            //StoreTrnsMClearanceco = new HashSet<StoreTrnsM>();
            //StoreTrnsMShipco = new HashSet<StoreTrnsM>();
            //StoreTrnsMShiptrns = new HashSet<StoreTrnsM>();
        }

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Companycode { get; set; }
        public string Companytype { get; set; }

        //public virtual ICollection<StoreTrnsM> StoreTrnsMClearanceco { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMShipco { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsMShiptrns { get; set; }
    }
}
