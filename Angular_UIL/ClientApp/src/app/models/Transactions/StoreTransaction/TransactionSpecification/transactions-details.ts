export class TransactionsDetails {
  constructor(
    public StoreTrnsMId?: number,
    //public ptransrowid?:number,
    public TrnsCode?: number,
    public TrnsNo?: number,
    public Storedocnum?: number,
    public BranchId?: number,
    public branch?: string,
    public Period?: number,
    public TrnsDate?: Date,
    public From_StoreAllcodesId?: number,
    public From_TypeName?: string,
    public From_StoreAllcodesName?: string,
    public To_StoreAllcodesId?: number,
    public TO_TypeName?: string,
    public To_StoreAllcodesName?: string,
    public transactionSelected?: boolean) { }



}
