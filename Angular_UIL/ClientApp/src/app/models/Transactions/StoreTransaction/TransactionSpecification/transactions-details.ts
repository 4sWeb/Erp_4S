import { FromType } from "./from-type";
import { ToType } from "./to-type";

export class TransactionsDetails {
  constructor
    (
    public From_Type: FromType[],
    public To_Type: ToType[],
    public StoreTrnsMId?: number,
    public TrnsCode?: number,
    public TrnsNo?: number,
    public Storedocnum?: number,
    public BranchId?: number,
    public branch?: string,
    public Period?: number,
    public TrnsDate?: Date,
    public From_StoreAllcodesId?: number,
    public From_StoreAllcodesName?: string,
    public To_StoreAllcodesId?: number,
    public To_StoreAllcodesName?: string,
    public transactionSelected?: boolean
  ) { }



}
