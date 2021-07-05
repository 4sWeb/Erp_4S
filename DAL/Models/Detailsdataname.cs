using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Detailsdataname
    {
        public Detailsdataname()
        {
            Companyinfos = new HashSet<Companyinfo>();
            GroupBasicData = new HashSet<GroupBasicDatum>();
        }

        public string Type { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal Detailsid { get; set; }

        public virtual ICollection<Companyinfo> Companyinfos { get; set; }
        public virtual ICollection<GroupBasicDatum> GroupBasicData { get; set; }
    }
}
