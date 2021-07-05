using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgOpenCase
    {
        public LgOpenCase()
        {
            LgDescriptionsMs = new HashSet<LgDescriptionsM>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Ename { get; set; }
        public string Aname { get; set; }

        public virtual ICollection<LgDescriptionsM> LgDescriptionsMs { get; set; }
    }
}
