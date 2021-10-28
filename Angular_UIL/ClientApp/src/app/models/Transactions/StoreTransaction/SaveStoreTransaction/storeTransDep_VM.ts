export class storeTransDep_VM {
  constructor(
    public Ptransrowid?: number,
    public Ctrnsrowid?: number,
    public Groupid?: number,
    public TrnsCode?: number,
    public TrnsNo?:number,
    public ToStoreAllcodesId?: number,
    public FromStoreAllcodesId?: number,
    public BranchId?: number,
    public StoreTrnsDepId?: number,
    public Depdetailsid?: number,
    public Depslot?: number,
    public Commited?: number,
    public TrnsDate?:Date,
    public Rem?: string,
    public BranchName?: string,
    public From_TypeName?: string,
    public TO_TypeName?: string,
    public From_StoreAllcodesName?: string,
    public To_StoreAllcodesName?: string,
  ) { }
}
