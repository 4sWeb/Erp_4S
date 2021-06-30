using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Usergroup
    {
        public Usergroup()
        {
            //Users = new HashSet<Users>();
        }
        [Key]
        public int UsergroupId { get; set; }
        public string Groupcode { get; set; }
        public string Groupname { get; set; }
        public string Note { get; set; }
        public decimal? Privilegeid { get; set; }
        public decimal? Pojectno { get; set; }
        public string Groupename { get; set; }
        public decimal? Active { get; set; }

       //public virtual ICollection<Users> Users { get; set; }
    }
}
