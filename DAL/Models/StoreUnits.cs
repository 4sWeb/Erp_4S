using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class StoreUnits
    {
        public StoreUnits()
        {
            //Productformladetails = new HashSet<Productformladetails>();
            //StoreItemUnits = new HashSet<StoreItemUnits>();
            //StoreTrnsO = new HashSet<StoreTrnsO>();
        }

        [Key]
        public int Unitid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Saname { get; set; }
        public string Sename { get; set; }

        //public virtual ICollection<Productformladetails> Productformladetails { get; set; }
        //public virtual ICollection<StoreItemUnits> StoreItemUnits { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsO { get; set; }
    }
}
