using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecPagesControl
    {
        public SecPagesControl()
        {
            SecRolesOnPagesControls = new HashSet<SecRolesOnPagesControl>();
        }

        public decimal Id { get; set; }
        public decimal? PageId { get; set; }
        public decimal? ControlId { get; set; }
        public decimal? Pagedataid { get; set; }

        public virtual SecControl Control { get; set; }
        public virtual SecPageDatum Pagedata { get; set; }
        public virtual ICollection<SecRolesOnPagesControl> SecRolesOnPagesControls { get; set; }
    }
}
