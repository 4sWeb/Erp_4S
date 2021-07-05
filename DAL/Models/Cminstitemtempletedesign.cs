using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemtempletedesign
    {
        public Cminstitemtempletedesign()
        {
            Cminstitemtempletes = new HashSet<Cminstitemtemplete>();
        }

        public decimal Id { get; set; }
        public decimal? Layoutid { get; set; }
        public bool? Serialstart { get; set; }
        public string Codepre { get; set; }
        public string Codepost { get; set; }
        public decimal? Seriallength { get; set; }

        public virtual Cminstitemlayoutlayer Layout { get; set; }
        public virtual ICollection<Cminstitemtemplete> Cminstitemtempletes { get; set; }
    }
}
