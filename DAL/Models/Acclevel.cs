using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Acclevel
    {
        public Acclevel()
        {
            Accountstrees = new HashSet<Accountstree>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Length { get; set; }
        public decimal? Levelno { get; set; }

        public virtual ICollection<Accountstree> Accountstrees { get; set; }
    }
}
