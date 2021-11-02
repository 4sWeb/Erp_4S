using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
    public class ProductSpecification_VM
    {
        public ProductSpecification_VM()
        {
            SelectedStoreTransMIds = new List<decimal>();
        }
        public List<decimal> SelectedStoreTransMIds { get; set; }
        public decimal Getitems { get; set; }
        public decimal DepPricType { get; set; }
    }
}
