using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class MainTypes
    {
        public MainTypes()
        {
            //Groupf = new HashSet<Groupf>();
            //StoreAllsubcodes = new HashSet<StoreAllsubcodes>();
            //StoreTrns = new HashSet<StoreTrns>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte Length { get; set; }
        public string Kind { get; set; }
        public bool System { get; set; }
        public int Id { get; set; }

        //public virtual ICollection<Groupf> Groupf { get; set; }
        //public virtual ICollection<StoreAllsubcodes> StoreAllsubcodes { get; set; }
        //public virtual ICollection<StoreTrns> StoreTrns { get; set; }
    }
}
