using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Permissoin
    {
        public Permissoin()
        {
            PagesPermissions = new HashSet<PagesPermission>();
        }

        public decimal PerId { get; set; }
        public string PerName { get; set; }
        public decimal PageId { get; set; }
        public string Arabicname { get; set; }
        public string Englishname { get; set; }
        public string Controltype { get; set; }

        public virtual ICollection<PagesPermission> PagesPermissions { get; set; }
    }
}
