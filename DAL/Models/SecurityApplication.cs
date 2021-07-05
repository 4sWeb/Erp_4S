using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityApplication
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Defaultpage { get; set; }
        public string DisplayInGl { get; set; }
        public string IsActive { get; set; }
        public string MessageKey { get; set; }
        public int? Position { get; set; }
    }
}
