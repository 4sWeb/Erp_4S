using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class GroupItemsUnits_VM
    {
        public decimal? GROUP_ID { get; set; }
        public decimal? ITEM_ID { get; set; }
        public decimal? UNIT_ID { get; set; }
        public decimal? BASIC_UNIT { get; set; }
        public string ITEM_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string ITEM_NAME { get; set; }
        public string UNIT_NAME { get; set; }
        public decimal? UNIT_RATE { get; set; }
        public decimal? PURCH_PRICE { get; set; }
        public decimal? SALES_PRICE { get; set; }
        public decimal? DEAL_PRICE { get; set; }
        public decimal? BRANCH_PRICE { get; set; }
        public decimal? RETAIL_PRICE { get; set; }



    }
}
