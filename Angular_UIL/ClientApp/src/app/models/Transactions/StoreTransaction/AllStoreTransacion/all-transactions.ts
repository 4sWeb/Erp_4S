export class AllTransactions {
  constructor(
    public StoreTrnsMId? : number,
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
    public To_StoreAllcodesName?: string

  ) {

  }
}


//"StoreTrnsMId": 7491,
//  "TrnsCode": 1,
//    "TrnsNo": 1,
//      "Storedocnum": 1,
//        "BranchId": 371,
//          "branch": "المركز الرئيسي - القاهرة",
//            "Period": 2,
//              "TrnsDate": "2021-04-25T00:00:00",
//                "From_StoreAllcodesId": 682,
//                  "From_TypeName": "ادارة",
//                    "From_StoreAllcodesName": "الادارة المالية - المركز الرئيسى",
//                      "To_StoreAllcodesId": 682,
//                        "TO_TypeName": "ادارة",
//                          "To_StoreAllcodesName": "الادارة المالية - المركز الرئيسى"
