using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsKindSpec
    {
        public StoreTrnsKindSpec()
        {
            StoreTrnsKindDetails = new HashSet<StoreTrnsKindDetail>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<StoreTrnsKindDetail> StoreTrnsKindDetails { get; set; }
    }
}
