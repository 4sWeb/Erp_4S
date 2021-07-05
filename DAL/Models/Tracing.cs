using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tracing
    {
        public string TName { get; set; }
        public string RState { get; set; }
        public string Key { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public string Action { get; set; }
    }
}
