using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlSetting
    {
        public decimal Id { get; set; }
        public bool? Revisebeforepost { get; set; }
        public bool? Jtypemtransmandatory { get; set; }
        public bool? Cancelpostingtransactivated { get; set; }
        public bool? Trialbudgetwithouttransstatus { get; set; }
    }
}
