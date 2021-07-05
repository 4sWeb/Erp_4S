using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Producationformla
    {
        public Producationformla()
        {
            Productformladetails = new HashSet<Productformladetail>();
        }

        public decimal Id { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Formlacode { get; set; }
        public bool? Defaultitem { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Productformladetail> Productformladetails { get; set; }
    }
}
