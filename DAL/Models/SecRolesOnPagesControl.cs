using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecRolesOnPagesControl
    {
        public decimal Id { get; set; }
        public decimal? PageControlId { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal? SecRoleId { get; set; }
        public decimal? Maxiamrate { get; set; }

        public virtual SecPagesControl PageControl { get; set; }
        public virtual Role Role { get; set; }
        public virtual SecRole SecRole { get; set; }
    }
}
