using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PagesPermission
    {
        public decimal PageId { get; set; }
        public decimal PerId { get; set; }
        public decimal RoleId { get; set; }
        public string PerStatus { get; set; }

        public virtual Permissoin Per { get; set; }
        public virtual Role Role { get; set; }
    }
}
