using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlOracleSpec
    {
        public string Code { get; set; }
        public string CurrencyCode { get; set; }
        public byte? Csegments { get; set; }
        public string Dbuser { get; set; }
        public string Dbpassword { get; set; }
        public string Dbservice { get; set; }
        public string Dbcatalogowner { get; set; }
        public byte? Defaultday { get; set; }
        public string JeCategoryName { get; set; }
        public string JeSourceName { get; set; }
        public long SetOfBooksId { get; set; }
        public long? CreatedBy { get; set; }
        public string GlCalenderName { get; set; }
    }
}
