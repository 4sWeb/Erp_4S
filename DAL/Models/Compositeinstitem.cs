using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Compositeinstitem
    {
        public Compositeinstitem()
        {
            Institems = new HashSet<Institem>();
        }

        public decimal Id { get; set; }
        public decimal? Code { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Bussinessid { get; set; }

        public virtual StoreAllsubcode Bussiness { get; set; }
        public virtual ICollection<Institem> Institems { get; set; }
    }
}
