using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Preferences
    {
        public decimal Userid { get; set; }
        [Key]
        public string Prefcode { get; set; }
        public string Value { get; set; }
        public decimal Preftype { get; set; }
    }
}
