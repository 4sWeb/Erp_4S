using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Codepart3
    {
        public decimal Id { get; set; }
        public string PartCode { get; set; }
        public string PartCodeName { get; set; }
        public string PartCodeEname { get; set; }
        public string ApartName { get; set; }
        public string EpartName { get; set; }
    }
}
