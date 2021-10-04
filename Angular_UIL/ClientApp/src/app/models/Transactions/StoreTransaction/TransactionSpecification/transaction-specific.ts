
import { Branches } from "./Branches";
import { ExtraField } from "./extra-field";
import { FromType } from "./from-type";
import { FromTypeDetails } from "./from-type-details";
import { ToType } from "./to-type";
import { ToTypeDetails } from "./to-type-details";
import { TransactionsName } from "./transactions-name";
import { TransactionDepSpec_VM } from "./transaction-dep-spec";
import { TransactionMasterSpec_VM } from "./transaction-master-spec";
import { Sales_Rep_VM } from "./Sales_Rep_VM";

export class TransactionSpecific {
  constructor(public TrnsCode?: number,
    public StoreTransMax?: number,
   public Aname?: string,
   public Ename?: string,
   public TrnsType?: number,
   public TrnsNature?: number,
   public SalesRep?: boolean,
   public PriceEffect?: boolean,
   public PayEffect?: boolean,
   public QtyEffect?: boolean,
   public ItemPrice?: number,
   public TrnsDisc?: boolean,
   public TrnsDiscRate?: number,
   public ItemDisc?: boolean,
   public Stax?: boolean,
   public StaxRate?: number,
   public Ctax?: boolean,
   public CtaxRate?: number,
   public ItemStax?: boolean,
   public StoreItemfromsSpecsId?: number,
   public FromStoreAllcodesId?: number,
   public ToStoreAllcodesId?: number,
   public Item2ndprice?: number,
   public ShowPrice?: boolean,
   public Show2ndprice?: boolean,
   public Item2ndpriceEffect?: boolean,
   public ItemPricelistId?: number,
   public GetPricelist?: boolean,
   public Shippingspecs?: boolean,
   public Shippingeffectonholder?: boolean,
   public TrnsnoCreation?: boolean,
   public TrnsnoRepeat?: boolean,
   public TrnsnoEdit?: boolean,
   public DocnumCreation?: boolean,
   public DocnumRepeat?: boolean,
   public DocnumEdit?: boolean,
   public CustmorDisc?: boolean,
   public Item2nddisc?: boolean,
   public Getdisclist?: boolean,
   public ItemDisclistId?: number,
   public Hascashpayment?: number,
   public Cashid?: number,
   public Financetranscode?: number,
   public Multycurrency?: number,
   public Needaccept?: boolean,
   public Acceptcount?: number,
   public Hasexpenses?: boolean,
   public ExpensesEffect?: boolean,
   public CtaxDisc?: boolean,
   public CtaxDiscRate?: number,
   public Financedistid?: number,
   public MainCostCenter?: boolean,
   public MainAccount?: boolean,
   public DetailCostCenter?: boolean,
   public DetailAccount?: boolean,
   public DepositFlag?: boolean,
   public AllowanceDateType?: boolean,
   public HasStartDate?: boolean,
   public HasEndDate?: boolean,
   public ShowBal?: boolean,
   public Costcentereffect?: boolean,
   public CustmorCtax?: boolean,
   public TransferCostType?: boolean,
   public Dsttype?: number,
   public Mustdsttype?: boolean,
   public Dstindetails?: boolean,
   public Dstdetailstype?: number,
   public Transrepeatonperiod?: boolean,
   public Docrepeatonperiod?: boolean,
   public Usebarcode?: boolean,
   public Showtax41?: boolean,
   public Showlc?: boolean,
   public Showdependdoc?: boolean,
   public Showcargo?: boolean,
   public Showtermsofpayment?: boolean,
   public Showrequireddocument?: boolean,
   public Showsupplyorderstatus?: boolean,
   public Showexpchoose?: boolean,
   public Reservation?: boolean,
   public Hasproductiondata?: boolean,
   public Noduplicateserial?: number,
   public Fromrequired?: boolean,
   public Torequired?: boolean,
   public Stage?: boolean,
   public Createitems?: boolean,
   public Approvedvendor?: boolean,
   public Committeeexist?: boolean,
   public Mobiletrans?: boolean,
   public Weekno?: boolean,
   public Fromtodate?: boolean,
   public Itemapproved?: boolean,
   public Begintime?: boolean,
   public Endtime?: boolean,
   public Safeperiod?: boolean,
   public Paymenttype?: boolean,
   public Deliveryplace?: boolean,
   public Inttradespec?: boolean,
   public Receivedate?: boolean,
   public Choicereason?: boolean,
   public Paymentspec?: boolean,
   public Committee?: number,
   public Irrigationneed?: boolean,
   public Pool?: boolean,
   public Allowqtyedit?: boolean,
   public Cargoexpected?: boolean,
   public Cargoactually?: boolean,
   public Cargopaper?: boolean,
   public Portarrival?: boolean,
   public Detentionrev?: boolean,
   public Releasetype?: boolean,
   public Licenseno?: boolean,
   public Licensedate?: boolean,
   public Agriitems?: boolean,
   public Typeid?: boolean,
   public Agridataid?: boolean,
   public Managername?: boolean,
   public Employeeno?: boolean,
   public Irrigatemachine?: boolean,
   public Watervolume?: boolean,
   public Actualspace?: boolean,
   public Waterpressure?: boolean,
   public Purpose?: boolean,
   public Injureid?: boolean,
   public Phi?: boolean,
   public Workingtime?: boolean,
   public Restrictionperiod?: boolean,
   public Requiredprocedure?: boolean,
   public Ageid?: boolean,
   public Agriid?: boolean,
   public Processid?: boolean,
   public Fertunit?: boolean,
   public Agriqty?: boolean,
   public Agridata?: boolean,
   public Fromtime?: boolean,
   public Totime?: boolean,
   public Soilcond?: boolean,
   public Weathercond?: boolean,
   public Enginepressure?: boolean,
   public Irrigationempshow?: boolean,
   public Agrinorepeat?: boolean,
   public Taxdiscprnt?: boolean,
   public ExpensesCurr?: boolean,
   public ExpensesRate?: boolean,
   public ExpensesDist?: boolean,
   public Showexptype?: boolean,
   public Showprodstage?: boolean,
   public Printcostprice?: string,
   public Showpopprice?: boolean,
   public Showfarm?: boolean,
   public Showagricontainer?: boolean,
   public Shipco?: boolean,
   public Shiptrns?: boolean,
   public Clearanceco?: boolean,
   public Shipport?: boolean,
   public Arrivalport?: boolean,
   public Shipboat?: boolean,
   public Shippolino?: boolean,
   public Shipweekno?: boolean,
   public Shiplotno?: boolean,
   public Itemclone?: boolean,
   public Getdisclist2?: boolean,
   public Showeditbtn?: boolean,
   public Itempriceavg?: boolean,
   public Freeitem?: number,
   public Pricedecpoint?: number,
   public Mustaccount?: boolean,
   public Mustdimension?: boolean,
   public Execperco?: boolean,
   public Prevperc?: boolean,
   public Customdocno?: string,
   public Customdocnoar?: string,
   public Customdocnoshow?: number,
   public Patchno?: boolean,
   public Lotasdocno?: boolean,
    public Hasattachments?: boolean,
    //public TransactionsNames?: TransactionsName[],
    public ExtraFields?: ExtraField[],
    //public From_Type?: FromType[],
    //public To_Type?: ToType[],
   // public TrnsList?: AllTransactions[],
    //public Branches?: Result[],
    //public FromTypeDetails?: FromTypeDetails[],
    //public ToTypeDetails?: ToTypeDetails[],
    public Sales_Rep_VM?: Sales_Rep_VM[],
    public TransactionDepSpec_VM?: TransactionDepSpec_VM,
    public TransactionMasterSpec_VM?: TransactionMasterSpec_VM,
  ) { }
}


//"TrnsCode": 1,
//"Aname": "طلب احتياجات",
// "Ename": null,
// "TrnsType": 1,
// "TrnsNature": 1,
// "SalesRep": false,
// "PriceEffect": false,
// "PayEffect": true,
// "QtyEffect": false,
// "ItemPrice": 0,
// "TrnsDisc": true,
// "TrnsDiscRate": 0,
//"ItemDisc": false,
// "Stax": true,
// "StaxRate": 0,
// "Ctax": true,
// "CtaxRate": 0,
// "ItemStax": false,
// "StoreItemfromsSpecsId": null,
// "FromStoreAllcodesId": null,
//  "ToStoreAllcodesId": null,
// "Item2ndprice": 1,
//"ShowPrice": true,
// "Show2ndprice": false,
// "Item2ndpriceEffect": false,
//"ItemPricelistId": 0,
//"GetPricelist": false,
// "Shippingspecs": false,
//"Shippingeffectonholder": false,
// "TrnsnoCreation": false,
// "TrnsnoRepeat": true,
//  "TrnsnoEdit": true,
//  "DocnumCreation": false,
//  "DocnumRepeat": true,
//  "DocnumEdit": true,
//  "CustmorDisc": false,
//  "Item2nddisc": false,
//  "Getdisclist": false,
//  "ItemDisclistId": null,
//  "Hascashpayment": 0,
//  "Cashid": null,
//  "Financetranscode": null,
//  "Multycurrency": 1,
//  "Needaccept": true,
//  "Acceptcount": null,
//  "Hasexpenses": true,
//  "ExpensesEffect": false,
//  "CtaxDisc": true,
//  "CtaxDiscRate": 0,
//  "Financedistid": 1,
//  "MainCostCenter": true,
//  "MainAccount": true,
//  "DetailCostCenter": null,
//  "DetailAccount": null,
//  "DepositFlag": false,




//  "AllowanceDateType": false,
//  "HasStartDate": true,
//  "HasEndDate": true,
//  "ShowBal": true,
//  "Costcentereffect": false,
//  "CustmorCtax": false,
//  "TransferCostType": null,
//  "Dsttype": null,
//  "Mustdsttype": null,
//  "Dstindetails": false,
//  "Dstdetailstype": null,
//  "Transrepeatonperiod": true,
//  "Docrepeatonperiod": true,
//  "Usebarcode": false,
//  "Showtax41": false,
//  "Showlc": true,
//  "Showdependdoc": true,




//"Showcargo": true,
//"Showtermsofpayment": true,
//"Showrequireddocument": true,
//"Showsupplyorderstatus": true,
//"Showexpchoose": false,
//"Reservation": false,
//"Hasproductiondata": false,
//"Noduplicateserial": 0,
//"Fromrequired": true,
//"Torequired": false,
//"Stage": true,
//"Createitems": false,
//"Approvedvendor": false,
//"Committeeexist": true,
//"Mobiletrans": false,
//"Weekno": false,
//"Fromtodate": false,
//"Itemapproved": true,
//"Begintime": false,
//"Endtime": false,
//"Safeperiod": false,
//"Paymenttype": true,
//"Deliveryplace": true,
//"Inttradespec": false,
//"Receivedate": true,
//"Choicereason": null,
//"Paymentspec": true,
//"Committee": 3,
//"Irrigationneed": true,
//"Pool": null,
//"Allowqtyedit": null,
//"Cargoexpected": true,
//"Cargoactually": true,
//"Cargopaper": true,
//"Portarrival": true,
//"Detentionrev": false,
//"Releasetype": false,
//"Licenseno": false,





//"Licensedate": false,
//"Agriitems": false,
//"Typeid": true,
//"Agridataid": true,
//"Managername": true,
//"Employeeno": true,
// "Irrigatemachine": true,
// "Watervolume": false,
// "Actualspace": false,
//  "Waterpressure": null,
//  "Purpose": false,
//  "Injureid": false,
//   "Phi": false,
 //"Workingtime": false,
 //"Restrictionperiod": false,
//     "Requiredprocedure": false,

//"Ageid": false,
//"Agriid": null,
//"Processid": false,
//"Fertunit": false,
//"Agriqty": false,
//"Agridata": null,
//"Fromtime": false,
//"Totime": false,
//"Soilcond": true,
//"Weathercond": true,
//"Enginepressure": false,
//"Irrigationempshow": true,
//"Agrinorepeat": false,
//"Taxdiscprnt": false,
//"ExpensesCurr": true,
//"ExpensesRate": true,
//"ExpensesDist": null,
//"Showexptype": false,
//"Showprodstage": false,
//"Printcostprice": "0",

//"Showpopprice": false,
//"Showfarm": false,
//"Showagricontainer": false,
//"Shipco": true,
//"Shiptrns": true,
//"Clearanceco": true,
//"Shipport": true,
//"Arrivalport": true,
//"Shipboat": true,
//"Shippolino": true,
//"Shipweekno": true,
//"Shiplotno": true,
//"Itemclone": false,
//"Getdisclist2": false,
//"Showeditbtn": false,
//"Itempriceavg": false,
//"Freeitem": 0,
//"Pricedecpoints": 0,
//"Mustaccount": false,
//"Mustdimension": false,
//"Execperco": false,
//"Prevperc": false,
//"Customdocno": null,
//"Customdocnoar": null,
//"Customdocnoshow": 1,
//"Patchno": true,
//"Lotasdocno": false,
//"Hasattachments": false,
////"TransactionsNames": []
