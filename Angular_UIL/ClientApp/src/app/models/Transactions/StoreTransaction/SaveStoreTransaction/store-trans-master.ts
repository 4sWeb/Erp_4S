import { Data } from "popper.js";
import { ToTypeDetails } from "../TransactionSpecification/to-type-details";
import { FromTypeDetails } from "../TransactionSpecification/from-type-details";
import { StoreTransDetails } from "./store-trans-details";
import { Result } from "../TransactionSpecification/Result";
import { FromType } from "../TransactionSpecification/from-type";
import { ToType } from "../TransactionSpecification/to-type";

export class StoreTransMaster {
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
    public StoreTrnsMId?: number,
  


    
  ) {}        
}
