using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class I18nMessage
    {
        public decimal Id { get; set; }
        public string Message { get; set; }
        public decimal? KeyId { get; set; }
        public decimal? Mylocale { get; set; }
    }
}
