using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Hafzaspec
    {
        public Hafzaspec()
        {
            Hafzams = new HashSet<Hafzam>();
        }

        public decimal Hafzatype { get; set; }
        public string CD { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Usefdist { get; set; }
        public string Usetdist { get; set; }
        public string Changestatus { get; set; }
        public byte? Status { get; set; }
        public string Changeplace { get; set; }
        public string Iscashing { get; set; }
        public string Isedit { get; set; }
        public bool? Affectownercheck { get; set; }
        public bool? Affectownercash { get; set; }
        public bool? Affectfromcheck { get; set; }
        public bool? Affectfromcash { get; set; }
        public bool? Affecttocheck { get; set; }
        public bool? Affecttocash { get; set; }
        public bool? Affectvendorcheck { get; set; }
        public bool? Affectvendorcash { get; set; }
        public string Signature1 { get; set; }
        public string Signature1name { get; set; }
        public string Signature2 { get; set; }
        public string Signature2name { get; set; }
        public string Signature3 { get; set; }
        public string Signature3name { get; set; }

        public virtual ICollection<Hafzam> Hafzams { get; set; }
    }
}
