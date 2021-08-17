using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsView
{
   public class StoreTransMaster_VM
    {
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public string Rem { get; set; }
        public DateTime TrnsDate { get; set; }
        public decimal? Storedocnum { get; set; }
        public decimal? Period { get; set; }
        public decimal StoreTrnsMId { get; set; }
        //need to enhace (generic class for ado) 
        public List<object> Branches { get; set; } 
        public List<object> From_Type { get; set; }  // ( Altaraf From )
        public List<object> To_Type { get; set; }    // ( Altaraf TO )
        public List<object> FromTypeDetails { get; set; }  // ( Altaraf From )
        public List<object> ToTypeDetails { get; set; }    // ( Altaraf TO )



        //public decimal? Disc { get; set; }
        //public decimal? DiscRate { get; set; }
        //public decimal? Stax { get; set; }
        //public decimal? StaxRate { get; set; }
        //public decimal? Ctax { get; set; }
        //public decimal? CtaxRate { get; set; }
        //public decimal? DepOnGroupno { get; set; }



        //public decimal? Total { get; set; }
        //public decimal? Currencyid { get; set; }


        //public decimal? Salesrep { get; set; }
        //public decimal? Currencyrate { get; set; }
        //public decimal? Initcash { get; set; }
        //public decimal? CtaxDisc { get; set; }
        //public decimal? CtaxDiscRate { get; set; }
        //public decimal? ExpensesAdd { get; set; }
        //public decimal? ExpensesDisc { get; set; }
        //public decimal? ExpensesNoeffect { get; set; }
        //public decimal? Pricelistid { get; set; }
        //public DateTime? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        //public int? PeriodLimit { get; set; }
        //public decimal? MainCostcenterid { get; set; }
        //public decimal? MainAccountid { get; set; }
        //public decimal? TransferCost { get; set; }
        //public decimal? Discountlistid { get; set; }
        //public decimal? Commited { get; set; }
        //public decimal? Instprogramid { get; set; }
        //public decimal? Tax41rate { get; set; }
        //public decimal? Tax41value { get; set; }
        //public decimal? Netvalue { get; set; }
        //public string Tax41trnsnatural { get; set; }
        //public decimal? Trnsusersid { get; set; }
        //public decimal? Disc2 { get; set; }
        //public decimal? Disc2Rate { get; set; }
        //public decimal? Addition1 { get; set; }
        //public decimal? Addition1Rate { get; set; }
        //public decimal? Addition2 { get; set; }
        //public decimal? Addition2Rate { get; set; }
        //public decimal? Addition3 { get; set; }
        //public decimal? Addition3Rate { get; set; }
        //public string Remark1 { get; set; }
        //public string Remark1e { get; set; }
        //public string Remark2 { get; set; }
        //public string Remark2e { get; set; }
        //public string Remark3 { get; set; }
        //public string Remark3e { get; set; }
        //public string Remark4 { get; set; }
        //public string Remark4e { get; set; }
        //public string Remark5 { get; set; }
        //public string Remark5e { get; set; }
        //public string Remark6 { get; set; }
        //public string Remark6e { get; set; }
        //public string Batchno { get; set; }
        //public string Numbervalue { get; set; }
        //public string Stringvalue { get; set; }
        //public decimal? Productionstageid { get; set; }
        //public string Createitems { get; set; }
        //public string Remark7 { get; set; }
        //public string Remark7e { get; set; }
        //public string Remark8 { get; set; }
        //public string Remark8e { get; set; }
        //public string Remark9 { get; set; }
        //public string Remark9e { get; set; }
        //public string Remark10 { get; set; }
        //public string Remark10e { get; set; }
        //public decimal? Irrigationneed { get; set; }
        //public string Paytypespec { get; set; }
        //public string Deliveryplace { get; set; }
        //public DateTime? Receivedate { get; set; }
        //public string Choicereason { get; set; }
        //public DateTime? Cargoexpected { get; set; }
        //public DateTime? Cargoactually { get; set; }
        //public DateTime? Portarrival { get; set; }
        //public bool? Cargopaper { get; set; }
        //public decimal? Typeid { get; set; }
        //public decimal? Agridataid { get; set; }
        //public string Managername { get; set; }
        //public decimal? Employeeno { get; set; }
        //public string Irrigatemachine { get; set; }
        //public string Weathercond { get; set; }
        //public string Soilcond { get; set; }
        //public string Createdby { get; set; }
        //public string Updatedby { get; set; }
        //public decimal? ExpensesCurr { get; set; }
        //public decimal? ExpensesRate { get; set; }
        //public bool? ExpensesNet { get; set; }
        //public decimal? Shipcoid { get; set; }
        //public decimal? Shiptrnsid { get; set; }
        //public decimal? Clearancecoid { get; set; }
        //public decimal? Shipportid { get; set; }
        //public decimal? Arrivalportid { get; set; }
        //public decimal? Shipboatid { get; set; }
        //public string Shippolino { get; set; }
        //public string Shipweekno { get; set; }
        //public string Shiplotno { get; set; }
        //public string Customdocno { get; set; }
        //public string Patchno { get; set; }

    }
}
