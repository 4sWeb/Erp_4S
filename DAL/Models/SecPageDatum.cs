using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecPageDatum
    {
        public SecPageDatum()
        {
            SecPagesControls = new HashSet<SecPagesControl>();
        }

        public decimal Id { get; set; }
        public decimal? Pageid { get; set; }
        public decimal? Dataid { get; set; }
        public decimal? SecRoleId { get; set; }
        public decimal? ApplicationId { get; set; }
        public decimal? RoleId { get; set; }

        public virtual ICollection<SecPagesControl> SecPagesControls { get; set; }
    }
}
