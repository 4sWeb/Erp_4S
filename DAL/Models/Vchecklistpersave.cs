using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vchecklistpersave
    {
        public decimal Checkid { get; set; }
        public decimal Checktype { get; set; }
        public string Checktypename { get; set; }
        public string Checktypeename { get; set; }
        public DateTime? Duedate { get; set; }
        public decimal? Amount { get; set; }
        public string Dname { get; set; }
        public string DEname { get; set; }
        public string Checkno { get; set; }
        public string Bankname { get; set; }
        public string Purpose { get; set; }
        public string Epurpose { get; set; }
        public long? Documentno { get; set; }
        public DateTime? Fstamp { get; set; }
        public string Curpos { get; set; }
        public string Ecurpos { get; set; }
        public string Status { get; set; }
        public string Estatus { get; set; }
        public string Curposcode { get; set; }
        public decimal? Branch { get; set; }
        public decimal? Trnscode { get; set; }
        public decimal Curposid { get; set; }
        public decimal Dnameid { get; set; }
        public decimal? Dnameform { get; set; }
        public decimal Dnametype { get; set; }
        public decimal Statusid { get; set; }
        public decimal Curpostype { get; set; }
        public decimal? CD { get; set; }
        public decimal? Curposform { get; set; }
    }
}
