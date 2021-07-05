using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Branchdirector
    {
        public decimal Id { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? StaffId { get; set; }
    }
}
