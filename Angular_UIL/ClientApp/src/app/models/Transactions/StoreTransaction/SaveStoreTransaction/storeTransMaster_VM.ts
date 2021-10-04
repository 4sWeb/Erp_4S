import { Data } from "popper.js";
import { ToTypeDetails } from "../TransactionSpecification/to-type-details";
import { FromTypeDetails } from "../TransactionSpecification/from-type-details";
import { Branches } from "../TransactionSpecification/Branches";
import { FromType } from "../TransactionSpecification/from-type";
import { ToType } from "../TransactionSpecification/to-type";

export class storeTransMaster_VM {
  constructor(


    public TrnsCode?: number,
    public TrnsNo?: number,         
    public TrnsDate?: Date, 
    public Rem?: string,
    public BranchId?: number,
    public Storedocnum?: number,
    public Period?: number,
    public FromStoreAllcodesId?: number,
    public ToStoreAllcodesId?: number,
    public storeTrnsMId?: number,
    public From_Type?: FromType,
    public To_Type?: ToType,
    public storeTransMax?: number,
    public disc?: number,
    public discRate?: number,
    public stax?: number,
    public staxRate?: number,
    public ctax?: number,
    public ctaxRate?: number,
    public depOnGroupno?: number,
    public ctaxDisc?: number,
    public ctaxDiscRate?: number,
    public total?: number,
    public currencyid?: number,
    public currencyrate?: number,
    public pricelistid?: number,
    public periodLimit?: number,
    public disc2?: number,
    public disc2Rate?: number,
    public addition1?: number,
    public addition1Rate?: number,
    public addition2?: number,
    public addition2Rate?: number,
    public addition3?: number,
    public addition3Rate?: number,
    public trnsusersid?: number,
    public employeeno?: number,
    public mainCostcenterid?: number,
    public mainAccountid?: number,
    public Salesrep?: number,


  ) {}        
}
