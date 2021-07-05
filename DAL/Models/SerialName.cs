using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SerialName
    {
        public decimal Id { get; set; }
        public byte? Serial { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
    }
}
