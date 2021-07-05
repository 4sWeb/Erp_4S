using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DistType
    {
        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte? Flength { get; set; }
        public string Ttype { get; set; }
        public byte? NoForms { get; set; }
        public int? ParentType { get; set; }
        public string Ttype2 { get; set; }
        public decimal Id { get; set; }
    }
}
