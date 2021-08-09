export class TransactionsDetails {
  constructor(
    public StoreTrnsMId?: number,
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
    public To_StoreAllcodesName?: string) { }


  //BranchId: 438
  //From_StoreAllcodesId: null
  //From_StoreAllcodesName: null
  //From_TypeName: null
  //Period: 1
  //StoreTrnsMId: 7282
  //Storedocnum: 7
  //TO_TypeName: "مورد"
  //To_StoreAllcodesId: 2445
  //To_StoreAllcodesName: "مشتريات نقدية"
  //TrnsCode: 5
  //TrnsDate: "2020-09-05T12:08:47"
  //TrnsNo: 7
  //branch: "مزرعة ابو منقار"

}
