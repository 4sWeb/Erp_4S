using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class ItemDetails_VM
    {
        public ItemDetails_VM()
        {
            Items_VMs = new List<Items_VM>();
            Unites_VMs = new List<Unites_VM>();


        }
        public List<Items_VM> Items_VMs { get; set; }
        public List<Unites_VM> Unites_VMs { get; set; }
        public int Price { get; set; }
    }
}
