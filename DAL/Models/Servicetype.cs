using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Servicetype
    {
        public Servicetype()
        {
            Attachmentservices = new HashSet<Attachmentservice>();
            Institemmaintypeservices = new HashSet<Institemmaintypeservice>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public string Institem1name { get; set; }
        public string Institem1ename { get; set; }
        public string UseInstitem1 { get; set; }
        public string UseInstitem1q { get; set; }
        public string Institem2name { get; set; }
        public string Institem2ename { get; set; }
        public string UseInstitem2 { get; set; }
        public string UseInstitem2q { get; set; }
        public string Institem3name { get; set; }
        public string Institem3ename { get; set; }
        public string UseInstitem3 { get; set; }
        public string UseInstitem3q { get; set; }
        public decimal? Defaultprice { get; set; }
        public decimal? Defaultprice2 { get; set; }
        public string Linkedtoparent1 { get; set; }
        public string Linkedtoparent2 { get; set; }
        public string Use1stpricepolicy1 { get; set; }
        public string Use1stpricepolicy2 { get; set; }
        public string Use2ndpricepolicy1 { get; set; }
        public string Use2ndpricepolicy2 { get; set; }
        public string Useallpricepolicy1 { get; set; }
        public string Useallpricepolicy2 { get; set; }
        public string Valueorratio1 { get; set; }
        public string Valueorratio2 { get; set; }
        public decimal? InstcalcmethodId { get; set; }
        public string Usedinmaintain { get; set; }

        public virtual Instcalcmethod Instcalcmethod { get; set; }
        public virtual ICollection<Attachmentservice> Attachmentservices { get; set; }
        public virtual ICollection<Institemmaintypeservice> Institemmaintypeservices { get; set; }
    }
}
