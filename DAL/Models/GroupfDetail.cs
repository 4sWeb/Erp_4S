using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GroupfDetail
    {
        public byte? Clevel { get; set; }
        public byte Length { get; set; }
        public decimal? RefType { get; set; }
        public decimal GroupfDetailsId { get; set; }
        public decimal? GroupfId { get; set; }
        public decimal? GroupfDetailsOriginalId { get; set; }

        public virtual Groupf Groupf { get; set; }
        public virtual MainType RefTypeNavigation { get; set; }
    }
}
