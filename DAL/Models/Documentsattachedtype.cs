using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Documentsattachedtype
    {
        public Documentsattachedtype()
        {
            Institemdocattachments = new HashSet<Institemdocattachment>();
            Rentformdocattachments = new HashSet<Rentformdocattachment>();
            Saleformdocattachments = new HashSet<Saleformdocattachment>();
            StoreItemsDocattachments = new HashSet<StoreItemsDocattachment>();
            Storeallcodesattachments = new HashSet<Storeallcodesattachment>();
            Storetrnsmattachments = new HashSet<Storetrnsmattachment>();
        }

        public decimal Id { get; set; }
        public string Doctypename { get; set; }
        public string Doctypeename { get; set; }
        public string Documenttype { get; set; }

        public virtual ICollection<Institemdocattachment> Institemdocattachments { get; set; }
        public virtual ICollection<Rentformdocattachment> Rentformdocattachments { get; set; }
        public virtual ICollection<Saleformdocattachment> Saleformdocattachments { get; set; }
        public virtual ICollection<StoreItemsDocattachment> StoreItemsDocattachments { get; set; }
        public virtual ICollection<Storeallcodesattachment> Storeallcodesattachments { get; set; }
        public virtual ICollection<Storetrnsmattachment> Storetrnsmattachments { get; set; }
    }
}
