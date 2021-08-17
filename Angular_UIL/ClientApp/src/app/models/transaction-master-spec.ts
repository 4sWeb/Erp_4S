import { FromType } from "./from-type";
import { ToType } from "./to-type";
import { ToTypeDetails } from "./to-type-details";
import { FromTypeDetails } from "./from-type-details";
import { Result } from "./Result";

export class TransactionMasterSpec {
  constructor(
    public From_Type?: FromType[],
    public To_Type?: ToType[],
    public FromTypeDetails?: FromTypeDetails[],
    public ToTypeDetails?: ToTypeDetails[],
    public Branches?: Result[],
    public TrnsCode?: number,
    public TrnsNo?: number,
    public Rem?: string
  ) {

  }
}
