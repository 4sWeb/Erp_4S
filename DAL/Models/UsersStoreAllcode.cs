using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UsersStoreAllcode
    {
        public decimal Id { get; set; }
        public decimal? UserId { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? MainTypesId { get; set; }
        public string Status { get; set; }

        public virtual MainType MainTypes { get; set; }
        public virtual StoreAllcode StoreAllcodes { get; set; }
        public virtual User User { get; set; }
    }
}
