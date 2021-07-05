using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonCountry
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public bool? Isdefault { get; set; }
        public string Malenationality { get; set; }
        public string Femalenationality { get; set; }
    }
}
