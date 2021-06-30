using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Groupf
    {
        public Groupf()
        {
            //GroupBasicData = new HashSet<GroupBasicData>();
            //StoreAllcodes = new HashSet<StoreAllcodes>();
        }

        public int? Codetype { get; set; }
        public decimal? Codeform { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Separator { get; set; }
        public byte? Noofpartions { get; set; }
        [Key]
        public int GroupfId { get; set; }
        public decimal? Codinglastpart { get; set; }
        public decimal? GroupfOriginalId { get; set; }
        public bool? Ingredients { get; set; }
        public bool? Containfertunit { get; set; }
        public decimal? Servgroup { get; set; }

        [ForeignKey("Codetype")]
        public virtual MainTypes CodetypeNavigation { get; set; }
        //[ForeignKey("")]
        public virtual StoreItemformsSpecs StoreItemformsSpecs { get; set; }
        //public virtual ICollection<GroupBasicData> GroupBasicData { get; set; }
        //public virtual ICollection<StoreAllcodes> StoreAllcodes { get; set; }
    }
}
