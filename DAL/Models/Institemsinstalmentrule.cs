using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemsinstalmentrule
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Instalmentrulesid { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual Instalmentrule Instalmentrules { get; set; }
    }
}
