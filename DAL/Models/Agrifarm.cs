using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Agrifarm
    {
        public Agrifarm()
        {
            StoreTrnsOs = new HashSet<StoreTrnsO>();
        }

        public decimal Id { get; set; }
        public string Ename { get; set; }
        public string Aname { get; set; }
        public string Code { get; set; }

        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
    }
}
