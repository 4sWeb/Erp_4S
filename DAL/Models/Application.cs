using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Application
    {
        public Application()
        {
            Financespecapps = new HashSet<Financespecapp>();
            Userreportsmenues = new HashSet<Userreportsmenue>();
        }

        public string AppName { get; set; }
        public string AppEname { get; set; }
        public decimal? AppPosition { get; set; }
        public DateTime? Createdate { get; set; }
        public string AppType { get; set; }
        public decimal AppId { get; set; }
        public string Keyword { get; set; }

        public virtual ICollection<Financespecapp> Financespecapps { get; set; }
        public virtual ICollection<Userreportsmenue> Userreportsmenues { get; set; }
    }
}
