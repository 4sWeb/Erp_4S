using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoretrnsmInstalmentsm
    {
        public StoretrnsmInstalmentsm()
        {
            StoretrnsmInstalmentos = new HashSet<StoretrnsmInstalmento>();
        }

        public decimal Id { get; set; }
        public decimal? StoreTrnsMId { get; set; }
        public decimal? Instalmentpartid { get; set; }
        public byte? Rank { get; set; }
        public byte? Instcount { get; set; }
        public decimal? Instpercent { get; set; }
        public short? Internalinterval { get; set; }
        public string Internalintervaltype { get; set; }
        public short? Externalinterval { get; set; }
        public string Externalintervaltype { get; set; }
        public string Externalbegintype { get; set; }
        public decimal? Noofmonths { get; set; }
        public string Insttype { get; set; }

        public virtual Instalmentpart Instalmentpart { get; set; }
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        public virtual ICollection<StoretrnsmInstalmento> StoretrnsmInstalmentos { get; set; }
    }
}
