using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UsersRole
    {
        public decimal RoleId { get; set; }
        public decimal Userid { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
