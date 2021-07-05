using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemattatchmentsu
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? AttatchmentId { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Unitval3 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Feautersvalue { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public decimal? InstprogramsId { get; set; }
        public decimal? Ownercompany { get; set; }
        public decimal? Servicesvalue { get; set; }
        public DateTime? Updatedate { get; set; }
        public decimal? Tableid { get; set; }
        public decimal? InstcalcmethodId { get; set; }

        public virtual Institemmaintypeattachment Attatchment { get; set; }
        public virtual Instcalcmethod Instcalcmethod { get; set; }
    }
}
