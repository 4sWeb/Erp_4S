using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
    public class GroupF_VM
    {
        public GroupF_VM()
        {
            items_VM = new List<Items_VM>();
        }
        public int GroupF_Id { get; set; }
        public string Aname { get; set; }
        public List<Items_VM> items_VM { get; set; }
    }
}
