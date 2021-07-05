using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Attachmenttype
    {
        public Attachmenttype()
        {
            Attachmentfeatures = new HashSet<Attachmentfeature>();
            Attachmentservices = new HashSet<Attachmentservice>();
            Institemmaintypeattachments = new HashSet<Institemmaintypeattachment>();
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
        public decimal? InstcalcmethodId { get; set; }

        public virtual Instcalcmethod Instcalcmethod { get; set; }
        public virtual ICollection<Attachmentfeature> Attachmentfeatures { get; set; }
        public virtual ICollection<Attachmentservice> Attachmentservices { get; set; }
        public virtual ICollection<Institemmaintypeattachment> Institemmaintypeattachments { get; set; }
    }
}
