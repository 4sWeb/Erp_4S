using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userstran
    {
        public Userstran()
        {
            Usertransctrls = new HashSet<Usertransctrl>();
        }

        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public string Transcode { get; set; }
        public string Transtype { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Usertransctrl> Usertransctrls { get; set; }
    }
}
