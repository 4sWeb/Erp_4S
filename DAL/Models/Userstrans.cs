using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Userstrans
    {
        [Key]
        public int Id { get; set; }
        public int? Userid { get; set; }
        public string Transcode { get; set; }
        public string Transtype { get; set; }

        [ForeignKey("Userid")]
        public virtual Users User { get; set; }
    }
}
