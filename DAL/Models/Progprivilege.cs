using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Progprivilege
    {
        public decimal ProprivilegeId { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Menuid { get; set; }
        public string Flag { get; set; }
        public decimal? UsergroupId { get; set; }
        public DateTime? Createdate { get; set; }
        public decimal? Projectno { get; set; }

        public virtual User User { get; set; }
        public virtual Usergroup Usergroup { get; set; }
    }
}
