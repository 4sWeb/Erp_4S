using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Role
    {
        public Role()
        {
            PagesPermissions = new HashSet<PagesPermission>();
            RolesPages = new HashSet<RolesPage>();
            SecRolesOnPagesControls = new HashSet<SecRolesOnPagesControl>();
            UsersRoles = new HashSet<UsersRole>();
        }

        public decimal RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<PagesPermission> PagesPermissions { get; set; }
        public virtual ICollection<RolesPage> RolesPages { get; set; }
        public virtual ICollection<SecRolesOnPagesControl> SecRolesOnPagesControls { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}
