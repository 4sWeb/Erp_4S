using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MainTypeCodeSegmentation1
    {
        public decimal MainId { get; set; }
        public string MainName { get; set; }
        public decimal GroupfId { get; set; }
        public string FormName { get; set; }
        public byte? Clevel { get; set; }
        public byte Length { get; set; }
        public decimal PartId { get; set; }
        public string ApartName { get; set; }
        public string EpartName { get; set; }
        public decimal? MaxClevel { get; set; }
        public decimal? UpTo { get; set; }
        public decimal? Codinglastpart { get; set; }
    }
}
