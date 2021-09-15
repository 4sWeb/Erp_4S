using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class Items_VM
    {
        public Items_VM()
        {
            unites_VM = new List<Unites_VM>();
        }
        public int itemId { get; set; }
        public string name { get; set; }
        public List<Unites_VM> unites_VM { get; set; }
    }
}
