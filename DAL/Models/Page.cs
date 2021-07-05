using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Page
    {
        public decimal Pageid { get; set; }
        public string Pagename { get; set; }
        public DateTime? Createdate { get; set; }
        public string PageTitle { get; set; }
        public string PageUrl { get; set; }
        public string Projectno { get; set; }
        public string Pageename { get; set; }
        public string Pageetitle { get; set; }
        public decimal? ParentId { get; set; }
        public string PageUrlrt { get; set; }
        public decimal? Ranking { get; set; }
        public string Pagertparam1 { get; set; }
        public string Pagertparam2 { get; set; }
        public decimal? Hidden { get; set; }
    }
}
