using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Period
    {
        public Period()
        {
            //StoreAllcodesBegin = new HashSet<StoreAllcodesBegin>();
            //Userperiod = new HashSet<Userperiod>();
        }
        [Key]
        public int Period1 { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string OpenClose { get; set; }

        //public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegin { get; set; }
        //public virtual ICollection<Userperiod> Userperiod { get; set; }
    }
}
