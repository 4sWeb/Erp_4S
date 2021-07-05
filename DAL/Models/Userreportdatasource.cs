using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userreportdatasource
    {
        public Userreportdatasource()
        {
            Userreportdatasourceos = new HashSet<Userreportdatasourceo>();
        }

        public decimal Id { get; set; }
        public string Tableviewname { get; set; }
        public string Tableardec { get; set; }
        public string Tableendec { get; set; }

        public virtual ICollection<Userreportdatasourceo> Userreportdatasourceos { get; set; }
    }
}
