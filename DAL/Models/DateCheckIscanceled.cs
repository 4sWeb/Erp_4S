﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DateCheckIscanceled
    {
        public decimal Checkid { get; set; }
        public DateTime? Dd { get; set; }
        public decimal? Flag { get; set; }
    }
}
