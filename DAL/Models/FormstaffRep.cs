using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FormstaffRep
    {
        public decimal? Id { get; set; }
        public string DocNo { get; set; }
        public decimal? Staff { get; set; }
        public decimal? Formstatustypes { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Flag { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? Mandatoryid { get; set; }
        public string Mandatorycode { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public decimal? InstitemMainTypesId { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
    }
}
