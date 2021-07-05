using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentadddeducreason
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public string Affectsalevalue { get; set; }
        public decimal Factor { get; set; }
    }
}
