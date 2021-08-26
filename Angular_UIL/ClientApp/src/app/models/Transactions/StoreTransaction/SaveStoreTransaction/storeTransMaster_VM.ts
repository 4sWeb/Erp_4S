import { Data } from "popper.js";
import { ToTypeDetails } from "../TransactionSpecification/to-type-details";
import { FromTypeDetails } from "../TransactionSpecification/from-type-details";
import { Result } from "../TransactionSpecification/Result";
import { FromType } from "../TransactionSpecification/from-type";
import { ToType } from "../TransactionSpecification/to-type";

export class storeTransMaster_VM {
  constructor(


    public trnsCode?: number,
    public trnsNo?: number,         
    public trnsDate?: Date, 
    public rem?: string,
    public branchId?: number,
    public storedocnum?: number,
    public period?: number,
    public fromStoreAllcodesId?: number,
    public toStoreAllcodesId?: number,
    public storeTrnsMId?: number,
  


    
  ) {}        
}
