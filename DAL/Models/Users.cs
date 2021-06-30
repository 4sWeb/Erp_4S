using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Users
    {
        public Users()
        {
            //AcceptInTrns = new HashSet<AcceptInTrns>();
            //Conditionsbooklet = new HashSet<Conditionsbooklet>();
            //Staff = new HashSet<Staff>();
            //StoreAllcodes = new HashSet<StoreAllcodes>();
            //Userperiod = new HashSet<Userperiod>();
            //Userstrans = new HashSet<Userstrans>();
        }

        [Key]
        public int Userid { get; set; }
        public string Usercode { get; set; }
        public string Username { get; set; }
        public string Userename { get; set; }
        public string Userpassword { get; set; }
        public string Positionapps { get; set; }
        public decimal? Active { get; set; }
        public DateTime? Createdate { get; set; }
        public int? UsergroupId { get; set; }
        public decimal? Projectno { get; set; }
        public decimal? Privilegeid { get; set; }
        public string Salt { get; set; }
        public string Uname { get; set; }

        [ForeignKey("UsergroupId")]
        public virtual Usergroup Usergroup { get; set; }
        //public virtual ICollection<AcceptInTrns> AcceptInTrns { get; set; }
        //public virtual ICollection<Conditionsbooklet> Conditionsbooklet { get; set; }
        //public virtual ICollection<Staff> Staff { get; set; }
        //public virtual ICollection<StoreAllcodes> StoreAllcodes { get; set; }
        //public virtual ICollection<Userperiod> Userperiod { get; set; }
        //public virtual ICollection<Userstrans> Userstrans { get; set; }
    }
}
