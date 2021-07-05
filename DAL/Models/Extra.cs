using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Extra
    {
        public Extra()
        {
            Storetrnsextras = new HashSet<Storetrnsextra>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Nameen { get; set; }
        public string Note { get; set; }
        public decimal? Extdttxt { get; set; }

        public virtual ICollection<Storetrnsextra> Storetrnsextras { get; set; }
    }
}
