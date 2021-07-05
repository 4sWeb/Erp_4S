using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecRole
    {
        public SecRole()
        {
            SecRolesOnPagesControls = new HashSet<SecRolesOnPagesControl>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<SecRolesOnPagesControl> SecRolesOnPagesControls { get; set; }
    }
}
