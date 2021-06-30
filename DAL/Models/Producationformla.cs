using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Producationformla
    {
        public Producationformla()
        {
            //Productformladetails = new HashSet<Productformladetails>();
        }

        public int Id { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? Creationdate { get; set; }
        public string Formlacode { get; set; }
        public bool? Defaultitem { get; set; }
        public string Notes { get; set; }

        //public virtual ICollection<Productformladetails> Productformladetails { get; set; }
    }
}
