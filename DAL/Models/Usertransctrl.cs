using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Usertransctrl
    {
        public decimal Id { get; set; }
        public decimal? Usertransid { get; set; }
        public decimal? Controlid { get; set; }

        public virtual SecControl Control { get; set; }
        public virtual Userstran Usertrans { get; set; }
    }
}
