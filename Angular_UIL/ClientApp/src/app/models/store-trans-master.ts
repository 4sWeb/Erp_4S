import { Data } from "popper.js";
import { Result } from "./Result";
import { FromType } from "./from-type";
import { ToType } from "./to-type";
import { ToTypeDetails } from "./to-type-details";
import { FromTypeDetails } from "./from-type-details";
import { StoreTransDetails } from "./store-trans-details";

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
    public From_Type?: FromType[],
    public To_Type?: ToType[],
    public FromTypeDetails?: FromTypeDetails[],
    public ToTypeDetails?: ToTypeDetails[],
    public Branches?: Result[],


    
  ) {}        
}
