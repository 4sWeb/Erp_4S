using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityUserBranch
    {
        public decimal Id { get; set; }
        public decimal? Userprivilege { get; set; }
        public string Branch { get; set; }
    }
}
