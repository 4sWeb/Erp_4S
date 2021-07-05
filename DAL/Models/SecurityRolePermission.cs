using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityRolePermission
    {
        public decimal Role { get; set; }
        public decimal Permission { get; set; }
    }
}
