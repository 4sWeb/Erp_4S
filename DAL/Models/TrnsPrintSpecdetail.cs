using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TrnsPrintSpecdetail
    {
        public decimal Id { get; set; }
        public decimal? TrnsPrintSpecId { get; set; }
        public string Disttype { get; set; }
        public decimal? GroupBasicDataId { get; set; }
        public decimal? Distcodetype { get; set; }

        public virtual GroupBasicDatum GroupBasicData { get; set; }
        public virtual TrnsPrintSpec TrnsPrintSpec { get; set; }
    }
}
