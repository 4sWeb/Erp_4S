using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreAllsubcodes
    {
        public StoreAllsubcodes()
        {
            //AgridataAgrioriginNavigation = new HashSet<Agridata>();
            //AgridataAgriway = new HashSet<Agridata>();
            //AgridataRaise = new HashSet<Agridata>();
            //StoreTrnsM = new HashSet<StoreTrnsM>();
            //StoreTrnsO = new HashSet<StoreTrnsO>();
        }

        public int Codetype { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        [Key]
        public int StoreAllsubcodesId { get; set; }
        public string FullCode { get; set; }
        public decimal? StoreAllsubcodesOriginalId { get; set; }
        public string Phoneno { get; set; }
        public string Faxno { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Addresse { get; set; }
        public string Rep { get; set; }
        public string Repe { get; set; }
        public string Note1 { get; set; }
        public string Note1e { get; set; }
        public string Note2 { get; set; }
        public string Note2e { get; set; }
        public int? Defaultitemid { get; set; }

        [ForeignKey("Codetype")]
        public virtual MainTypes CodetypeNavigation { get; set; }
        [ForeignKey("Defaultitemid")]
        public virtual StoreItems Defaultitem { get; set; }
        //public virtual ICollection<Agridata> AgridataAgrioriginNavigation { get; set; }
        //public virtual ICollection<Agridata> AgridataAgriway { get; set; }
        //public virtual ICollection<Agridata> AgridataRaise { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
        //public virtual ICollection<StoreTrnsO> StoreTrnsO { get; set; }
    }
}
