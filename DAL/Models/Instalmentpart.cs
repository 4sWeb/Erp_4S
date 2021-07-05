using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instalmentpart
    {
        public Instalmentpart()
        {
            InstalmentsMs = new HashSet<InstalmentsM>();
            Saleforminstalmentsms = new HashSet<Saleforminstalmentsm>();
            Saleinstalmentsos = new HashSet<Saleinstalmentso>();
            StoretrnsmInstalmentos = new HashSet<StoretrnsmInstalmento>();
            StoretrnsmInstalmentsms = new HashSet<StoretrnsmInstalmentsm>();
        }

        public decimal Id { get; set; }
        public byte? Rank { get; set; }
        public string Descr { get; set; }
        public string Edescr { get; set; }
        public string SerialName { get; set; }
        public string SerialEname { get; set; }
        public string IsReserve { get; set; }
        public string IsContract { get; set; }
        public string IsEnd { get; set; }
        public string Punish { get; set; }
        public string Expensess { get; set; }

        public virtual ICollection<InstalmentsM> InstalmentsMs { get; set; }
        public virtual ICollection<Saleforminstalmentsm> Saleforminstalmentsms { get; set; }
        public virtual ICollection<Saleinstalmentso> Saleinstalmentsos { get; set; }
        public virtual ICollection<StoretrnsmInstalmento> StoretrnsmInstalmentos { get; set; }
        public virtual ICollection<StoretrnsmInstalmentsm> StoretrnsmInstalmentsms { get; set; }
    }
}
