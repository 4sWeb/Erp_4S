using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecRolesOnPage
    {
        public decimal Id { get; set; }
        public decimal? PageId { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? SecRoleId { get; set; }
    }
}
