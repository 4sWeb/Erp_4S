using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Groupf
    {
        public Groupf(ModelContext context)
        {
            GroupBasicData = new HashSet<GroupBasicDatum>();
            GroupfDetails = new HashSet<GroupfDetail>();
            StoreAllcodes = new HashSet<StoreAllcode>();
        }

        public decimal? Codetype { get; set; }
        public decimal? Codeform { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Separator { get; set; }
        public byte? Noofpartions { get; set; }
        public decimal GroupfId { get; set; }
        public decimal? Codinglastpart { get; set; }
        public decimal? GroupfOriginalId { get; set; }
        public bool? Ingredients { get; set; }
        public bool? Containfertunit { get; set; }
        public decimal? Servgroup { get; set; }

        public virtual MainType CodetypeNavigation { get; set; }
        public virtual StoreItemformsSpec StoreItemformsSpec { get; set; }
        public virtual ICollection<GroupBasicDatum> GroupBasicData { get; set; }
        public virtual ICollection<GroupfDetail> GroupfDetails { get; set; }
        public virtual ICollection<StoreAllcode> StoreAllcodes { get; set; }
    }
}
