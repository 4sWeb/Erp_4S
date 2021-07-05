using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Printcheckscontrolsname
    {
        public Printcheckscontrolsname()
        {
            Printcheckssettingdetails = new HashSet<Printcheckssettingdetail>();
        }

        public decimal Id { get; set; }
        public string Controlname { get; set; }
        public string Controlidname { get; set; }

        public virtual ICollection<Printcheckssettingdetail> Printcheckssettingdetails { get; set; }
    }
}
