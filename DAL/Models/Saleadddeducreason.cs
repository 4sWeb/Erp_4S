using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleadddeducreason
    {
        public Saleadddeducreason()
        {
            Saleinsatlementsadddeducs = new HashSet<Saleinsatlementsadddeduc>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Factor { get; set; }
        public string AffectSaleValue { get; set; }
        public string Valueorratio { get; set; }
        public decimal? Ontotalform { get; set; }
        public decimal? Defaultvalue { get; set; }

        public virtual ICollection<Saleinsatlementsadddeduc> Saleinsatlementsadddeducs { get; set; }
    }
}
