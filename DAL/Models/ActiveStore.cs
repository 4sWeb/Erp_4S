using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ActiveStore
    {
        public string BranchCode { get; set; }
        public string StoreCode { get; set; }
        public string UserId { get; set; }
        public DateTime? CreationTime { get; set; }
    }
}
