export class storeTransDep_VM {
  constructor(
    public ptransrowid?: number,
    public ctrnsrowid?: number,
    public groupid?: number,
    public trnsCode?: number,
    public trnsNo?:number,
    public toStoreAllcodesId?: number,
    public fromStoreAllcodesId?: number,
    public branchId?: number,
    public storeTrnsDepId?: number,
    public depdetailsid?: number,
    public depslot?: number,
    public commited?: number,
    public trnsDate?:Date,
    public rem?: string,
    public branchName?: string,
    public from_TypeName?: string,
    public tO_TypeName?: string,
    public from_StoreAllcodesName?: string,
    public to_StoreAllcodesName?: string,
  ) { }
}
