using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlSuspensionDetail
    {
        public decimal Id { get; set; }
        public decimal? Mastertransaction { get; set; }
        public string Suspensionnote { get; set; }
        public decimal? Suspensionemployee { get; set; }
        public DateTime? Suspensiondate { get; set; }
        public string Suspensionreplynote { get; set; }
        public decimal? Suspensionreplyemployee { get; set; }
        public DateTime? Suspensionreplydate { get; set; }
        public bool? Disabled { get; set; }
        public bool? Active { get; set; }
    }
}
