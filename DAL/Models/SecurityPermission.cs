using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityPermission
    {
        public decimal Id { get; set; }
        public string Permessionname { get; set; }
        public decimal? Selected { get; set; }
        public decimal? Fieldid { get; set; }
        public string Permissiondescription { get; set; }
    }
}
