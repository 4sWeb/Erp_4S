using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgCategory
    {
        public LgCategory()
        {
            LgDescriptionsMs = new HashSet<LgDescriptionsM>();
            LgTransactionEdits = new HashSet<LgTransactionEdit>();
            LgTransactions = new HashSet<LgTransaction>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Ename { get; set; }
        public string Aname { get; set; }

        public virtual ICollection<LgDescriptionsM> LgDescriptionsMs { get; set; }
        public virtual ICollection<LgTransactionEdit> LgTransactionEdits { get; set; }
        public virtual ICollection<LgTransaction> LgTransactions { get; set; }
    }
}
