using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Userperiod
    {
        [Key]
        public int Userid { get; set; }
        public int Periodid { get; set; }

        [ForeignKey("Periodid")]
        public virtual Period Period { get; set; }
        public virtual Users User { get; set; }
    }
}
