using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecControl
    {
        public SecControl()
        {
            SecPagesControls = new HashSet<SecPagesControl>();
            Usertransctrls = new HashSet<Usertransctrl>();
        }

        public decimal Id { get; set; }
        public string ControlId { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Status { get; set; }

        public virtual ICollection<SecPagesControl> SecPagesControls { get; set; }
        public virtual ICollection<Usertransctrl> Usertransctrls { get; set; }
    }
}
