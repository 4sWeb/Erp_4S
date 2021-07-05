﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AccountOwnValue
    {
        public decimal Accounttreeid { get; set; }
        public string Code { get; set; }
        public decimal? Journalentrymainid { get; set; }
        public decimal? Journalentrytypeid { get; set; }
        public DateTime? Entrydate { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? Parentid { get; set; }
        public bool? Isdetailedaccount { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
