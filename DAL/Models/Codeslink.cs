using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Codeslink
    {
        public Codeslink()
        {
            Codelinkpartdetails = new HashSet<Codelinkpartdetail>();
            Codelinkservaccs = new HashSet<Codelinkservacc>();
            Codeslinkdetails = new HashSet<Codeslinkdetail>();
            Codeslinkitemdetails = new HashSet<Codeslinkitemdetail>();
            Glintegratoros = new HashSet<Glintegratoro>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? Maintypeid { get; set; }

        public virtual Accountstree Account { get; set; }
        public virtual MainType Maintype { get; set; }
        public virtual ICollection<Codelinkpartdetail> Codelinkpartdetails { get; set; }
        public virtual ICollection<Codelinkservacc> Codelinkservaccs { get; set; }
        public virtual ICollection<Codeslinkdetail> Codeslinkdetails { get; set; }
        public virtual ICollection<Codeslinkitemdetail> Codeslinkitemdetails { get; set; }
        public virtual ICollection<Glintegratoro> Glintegratoros { get; set; }
    }
}
