using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PortalReportparameter
    {
        public decimal Id { get; set; }
        public string Reportparamtype { get; set; }
        public string Reportdisplayname { get; set; }
        public string Reportparamname { get; set; }
        public string Fieldorder { get; set; }
        public string Bindedfeild { get; set; }
        public string Query { get; set; }
        public string Dependablefield { get; set; }
        public string Defaultvalue { get; set; }
        public bool? Hide { get; set; }
        public string Notes { get; set; }
        public decimal? Reportid { get; set; }
        public string Parameterfieldname { get; set; }
    }
}
