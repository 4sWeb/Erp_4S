using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Glintegratoro
    {
        public decimal Id { get; set; }
        public decimal? Glintegratormid { get; set; }
        public decimal? Codelinkid { get; set; }
        public bool? Getdimension { get; set; }
        public decimal? Accountnatureid { get; set; }
        public string FromTo { get; set; }
        public decimal? IntgOrgVariablesid { get; set; }
        public string Note { get; set; }
        public string Getindiv { get; set; }

        public virtual Accountnature Accountnature { get; set; }
        public virtual Codeslink Codelink { get; set; }
        public virtual Glintegratorm Glintegratorm { get; set; }
        public virtual IntgOrgVariable IntgOrgVariables { get; set; }
    }
}
