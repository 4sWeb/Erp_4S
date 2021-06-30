using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Storemextras
    {
        public int Id { get; set; }
        public int? Storemid { get; set; }
        public int? Extrasid { get; set; }
        public string Value { get; set; }
        public string Valuear { get; set; }

        [ForeignKey("Extrasid")]
        public virtual Storetrnsextras Extras { get; set; }
        [ForeignKey("Storemid")]
        public virtual StoreTrnsM Storem { get; set; }
    }
}
