using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ERPModelsView
{
   public class TransactionDepSpec_VM
    {
        public TransactionDepSpec_VM()
        {
           TransactionsNames = new List<TransactionsNames_VM>();
        }
        public object TrnsList { get; set; }
        public List<TransactionsNames_VM> TransactionsNames { get; set; }
    }
}
