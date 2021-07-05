using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financedepspec
    {
        public Financedepspec()
        {
            Financedeps = new HashSet<Financedep>();
            Financedepspecdetails = new HashSet<Financedepspecdetail>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public decimal? Financespecid { get; set; }
        public string Notes { get; set; }

        public virtual Financespec Financespec { get; set; }
        public virtual ICollection<Financedep> Financedeps { get; set; }
        public virtual ICollection<Financedepspecdetail> Financedepspecdetails { get; set; }
    }
}
