using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class I18nKey
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
