using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemlayoutlayer
    {
        public Cminstitemlayoutlayer()
        {
            Cminstitemtempletedesigns = new HashSet<Cminstitemtempletedesign>();
        }

        public decimal Id { get; set; }
        public decimal? Buildinglayerid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Rank { get; set; }
        public string Codepre { get; set; }
        public string Codepost { get; set; }
        public decimal? Seriallength { get; set; }
        public bool? Serialstart { get; set; }
        public decimal? Institemtype { get; set; }
        public decimal? Layoutcount { get; set; }
        public decimal? Serialstartwith { get; set; }

        public virtual Cminstitembuildinglayer Buildinglayer { get; set; }
        public virtual Institemmaintype InstitemtypeNavigation { get; set; }
        public virtual ICollection<Cminstitemtempletedesign> Cminstitemtempletedesigns { get; set; }
    }
}
