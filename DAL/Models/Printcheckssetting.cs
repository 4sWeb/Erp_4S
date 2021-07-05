using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Printcheckssetting
    {
        public Printcheckssetting()
        {
            Printcheckssettingdetails = new HashSet<Printcheckssettingdetail>();
        }

        public decimal Id { get; set; }
        public string Checklang { get; set; }
        public string Checksettingname { get; set; }

        public virtual ICollection<Printcheckssettingdetail> Printcheckssettingdetails { get; set; }
    }
}
