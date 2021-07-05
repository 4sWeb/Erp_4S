using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Reservedunitsview
    {
        public DateTime? Indatenow { get; set; }
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? ReservedBy { get; set; }
        public DateTime? Indate { get; set; }
    }
}
