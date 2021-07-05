using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financespecapp
    {
        public decimal Financespecappid { get; set; }
        public decimal? Appid { get; set; }
        public decimal? Financespecid { get; set; }
        public decimal? Id { get; set; }

        public virtual Application App { get; set; }
    }
}
