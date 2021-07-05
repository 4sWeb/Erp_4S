using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleforminstalmentsm
    {
        public Saleforminstalmentsm()
        {
            Saleinstalmentsos = new HashSet<Saleinstalmentso>();
        }

        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Instalmentpartid { get; set; }
        public decimal? Tableid { get; set; }
        public string Tableflag { get; set; }
        public byte? Rank { get; set; }
        public byte? Instcount { get; set; }
        public decimal? Instpercent { get; set; }
        public short? Internalinterval { get; set; }
        public string Internalintervaltype { get; set; }
        public short? Externalinterval { get; set; }
        public string Externalintervaltype { get; set; }
        public string Externalbegintype { get; set; }
        public decimal? Noofmonths { get; set; }
        public decimal? Saleforminsprogramid { get; set; }
        public string Insttype { get; set; }

        public virtual Instalmentpart Instalmentpart { get; set; }
        public virtual Saleform Saleform { get; set; }
        public virtual ICollection<Saleinstalmentso> Saleinstalmentsos { get; set; }
    }
}
