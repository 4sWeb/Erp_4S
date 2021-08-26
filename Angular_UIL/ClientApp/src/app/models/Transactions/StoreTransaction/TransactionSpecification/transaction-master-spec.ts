import { FromType } from "./from-type";
import { ToType } from "./to-type";
import { ToTypeDetails } from "./to-type-details";
import { FromTypeDetails } from "./from-type-details";
import { Result } from "./Result";
import { Branches } from "./branches";

export class TransactionMasterSpec_VM {
  constructor(
    public From_Type?: FromType[],
    public To_Type?: ToType[],
    public FromTypeDetails?: FromTypeDetails[],
    public ToTypeDetails?: ToTypeDetails[],
    public Branches?: Result[],
  
  ) {

  }
}
