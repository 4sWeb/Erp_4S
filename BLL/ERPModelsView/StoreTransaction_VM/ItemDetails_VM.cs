using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class ItemDetails_VM
    {
        public ItemDetails_VM()
        {
            items_VM = new List<Items_VM>();
            unites_VM = new List<Unites_VM>();


        }
        public List<Items_VM> items_VM { get; set; }
        public List<Unites_VM> unites_VM { get; set; }
        public int Price { get; set; }
    }
}
