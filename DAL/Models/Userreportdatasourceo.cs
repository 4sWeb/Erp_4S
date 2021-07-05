using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userreportdatasourceo
    {
        public decimal Id { get; set; }
        public decimal? Userreportdatasourceid { get; set; }
        public string Columnname { get; set; }
        public string Columnardec { get; set; }
        public string Columnendec { get; set; }

        public virtual Userreportdatasource Userreportdatasource { get; set; }
    }
}
