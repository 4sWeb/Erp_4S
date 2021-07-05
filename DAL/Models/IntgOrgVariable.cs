using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class IntgOrgVariable
    {
        public IntgOrgVariable()
        {
            Glintegratoros = new HashSet<Glintegratoro>();
        }

        public string OrgTrnsType { get; set; }
        public string OrgTrnsVariable { get; set; }
        public string OrgTrnsVariableDesc { get; set; }
        public string EngDesc { get; set; }
        public int? DispOrder { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<Glintegratoro> Glintegratoros { get; set; }
    }
}
