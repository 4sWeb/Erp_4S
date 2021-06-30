using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Staff
    {
        public int Id { get; set; }
        public int? Personid { get; set; }
        public decimal? Staffclassid { get; set; }
        public decimal? Subclassid { get; set; }
        public decimal? Supervisorid { get; set; }
        public decimal? Stafflevelid { get; set; }
        public int? Userid { get; set; }
        public decimal? Managerid { get; set; }

        [ForeignKey("Personid")]
        public virtual StoreAllcodes Person { get; set; }
        [ForeignKey("Userid")]
        public virtual Users User { get; set; }
    }
}
