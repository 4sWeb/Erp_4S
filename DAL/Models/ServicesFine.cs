using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesFine
    {
        public ServicesFine()
        {
            ServicesRequestsmFines = new HashSet<ServicesRequestsmFine>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Ratio { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? UpdatedUser { get; set; }
        public decimal? IsActive { get; set; }

        public virtual ICollection<ServicesRequestsmFine> ServicesRequestsmFines { get; set; }
    }
}
