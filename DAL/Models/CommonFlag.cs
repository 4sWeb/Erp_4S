using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonFlag
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool? Flag { get; set; }
    }
}
