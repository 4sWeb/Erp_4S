using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class RolesPage
    {
        public decimal RoleId { get; set; }
        public decimal PageId { get; set; }

        public virtual Role Role { get; set; }
    }
}
