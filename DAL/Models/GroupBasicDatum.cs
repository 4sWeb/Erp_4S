using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GroupBasicDatum
    {
        public GroupBasicDatum()
        {
            TrnsPrintSpecdetails = new HashSet<TrnsPrintSpecdetail>();
        }

        public decimal GroupBasicId { get; set; }
        public decimal? DetailsId { get; set; }
        public string Attribute { get; set; }
        public decimal? GroupfId { get; set; }
        public bool? Requiredfield { get; set; }
        public decimal? Rank { get; set; }
        public string Coltype { get; set; }
        public bool? Uniquefield { get; set; }
        public bool? Showincontract { get; set; }
        public decimal? Groupfdetailid { get; set; }
        public string Attributeen { get; set; }

        public virtual Detailsdataname Details { get; set; }
        public virtual Groupf Groupf { get; set; }
        public virtual ICollection<TrnsPrintSpecdetail> TrnsPrintSpecdetails { get; set; }
    }
}
