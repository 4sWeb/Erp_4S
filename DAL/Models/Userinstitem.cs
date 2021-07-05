using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userinstitem
    {
        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Institemid { get; set; }

        public virtual User User { get; set; }
    }
}
