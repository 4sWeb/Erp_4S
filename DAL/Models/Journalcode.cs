using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Journalcode
    {
        public Journalcode()
        {
            Journalcodesaccs = new HashSet<Journalcodesacc>();
            Journalentriesmains = new HashSet<Journalentriesmain>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Shortaname { get; set; }
        public string Shortename { get; set; }
        public string Shapeentry { get; set; }
        public decimal? Startwithnum { get; set; }
        public decimal? Monthlynumber { get; set; }
        public decimal? Isdefault { get; set; }
        public decimal? Autoentry { get; set; }
        public decimal? Entrylength { get; set; }
        public decimal? Getindiv { get; set; }

        public virtual ICollection<Journalcodesacc> Journalcodesaccs { get; set; }
        public virtual ICollection<Journalentriesmain> Journalentriesmains { get; set; }
    }
}
