using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ShippingTemp
    {
        public decimal Shippingid { get; set; }
        public decimal? StoreTrnsMId { get; set; }
        public decimal? Shippingholderid { get; set; }
        public decimal? Driverid { get; set; }
        public decimal? Carid { get; set; }
        public int? Cartype { get; set; }
        public decimal? Fromid { get; set; }
        public decimal? Toid { get; set; }
        public decimal? Shippingcustomerid { get; set; }
        public string Drivername { get; set; }
        public string Licnumber { get; set; }
        public string Phonenumber { get; set; }
        public string Carnumber { get; set; }
        public string Carowner { get; set; }
        public decimal? Shippingcost { get; set; }
        public decimal? Shippingtaxvalue { get; set; }
        public decimal? Shippingtaxratio { get; set; }
        public decimal? Totalshippingcost { get; set; }
        public string Notes { get; set; }
        public int? Shipcode { get; set; }
        public bool? Approval { get; set; }
        public decimal? Commited { get; set; }
        public string Rowstate { get; set; }

        public virtual StoreTrnsMTemp StoreTrnsM { get; set; }
    }
}
