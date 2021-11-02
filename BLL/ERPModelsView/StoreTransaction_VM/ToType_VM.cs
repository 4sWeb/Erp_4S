using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class ToType_VM
    {
        public decimal ToType_Id { get; set; }
        public string Name { get; set; }
        public List< ToTypeDetails_VM >ToTypeDetails { get; set; }
    }
}
