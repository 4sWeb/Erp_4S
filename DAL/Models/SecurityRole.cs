using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityRole
    {
        public decimal Id { get; set; }
        public string Rolename { get; set; }
        public decimal? Application { get; set; }
        public string Defaultpage { get; set; }
    }
}
