using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
  public  class FromType_VM
    {
        public decimal FromType_Id { get; set; }
        public string Name { get; set; }
        public List< FromTypeDetails_VM> FromTypeDetails { get; set; }
    }
}
