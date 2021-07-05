using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentinstalmentso
    {
        public Rentinstalmentso()
        {
            Financeinstalments = new HashSet<Financeinstalment>();
        }

        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Rentinstalmenttypesid { get; set; }
        public decimal? Val { get; set; }
        public DateTime? Indate { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Rentinstalmentsmid { get; set; }
        public decimal? Tax { get; set; }
        public string Notes { get; set; }

        public virtual Rentform Rentform { get; set; }
        public virtual Rentinstalmentsm Rentinstalmentsm { get; set; }
        public virtual ICollection<Financeinstalment> Financeinstalments { get; set; }
    }
}
