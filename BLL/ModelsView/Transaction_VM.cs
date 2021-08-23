using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
    public class Transaction_VM
    {
        public Transaction_VM()
        {
           
        }
        public decimal StoreTrnsMId { get; set; }
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public decimal? Storedocnum { get; set; }
        public decimal? BranchId { get; set; }
        public string branch { get; set; }
        public decimal? Period { get; set; }
        public DateTime TrnsDate { get; set; }
        public decimal? From_StoreAllcodesId { get; set; } // Altaraf From (ID)
        public string From_TypeName { get; set; }
        public string From_StoreAllcodesName { get; set; }  // Altaraf From (Name)
        public decimal? To_StoreAllcodesId { get; set; } // Altaraf TO (ID)
        public string TO_TypeName { get; set; }
        public string To_StoreAllcodesName { get; set; } // Altaraf TO (Name)
        public StoreTransDep_VM StoreTransDep_VM { get; set; }
    }

    //return data of transdep 
    //public StoreTransDep_VM RetrieveTransactions(decimal storeTrnsMId)
    //{
    //    if (storeTrnsMId != default)
    //    {
    //        var oneItem = GetByCondition(c => c.Ctrnsrowid == storeTrnsMId).Result.Select(s => new StoreTransDep_VM
    //        {
    //            Ptransrowid = s.Ptransrowid,
    //            Groupid = s.Groupid,
    //        }
    //            ).FirstOrDefault();
    //        return oneItem;
    //    }
    //    return null;
    //}


    //return data of transdep 
    //public List<StoreTransDep_VM> RetrieveTransactions(List<decimal> storeTrnsMIds)
    //{
    //    List<StoreTransDep_VM> ListItem = new List<StoreTransDep_VM>();
    //    if (storeTrnsMIds != null)
    //    {
    //        foreach (var item in storeTrnsMIds)
    //        {
    //            var oneItem = GetByCondition(c => c.Ctrnsrowid == item).Result.Select(s => new StoreTransDep_VM
    //            {
    //                Ptransrowid = s.Ptransrowid,
    //                Groupid = s.Groupid,

    //            }
    //            ).FirstOrDefault();
    //            ListItem.Add(oneItem);
    //        }

    //        return ListItem;
    //    }

    //    return null;
    //}
}
