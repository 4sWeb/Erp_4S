import { Injectable } from '@angular/core';
import { storeTransMaster_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransMaster_vm';

@Injectable({
  providedIn: 'root'
})
export class SharingDataService {

  constructor() { }
  private operationType: any = undefined;

  private storeTransMId: any = undefined;

  private fromStoreAllCodesId: any = undefined;

  private toStoreAllCodesId: any = undefined;

  private storeId: any = undefined;
  CurrentTrnsName: string;

  setOperationType(data: any) {
    this.operationType = data;
  }

  getOperationType(): any {
    return this.operationType;
  }

  setStoreTransMId(data:any) {
    this.storeTransMId =data;
  }
  getStoreTransMId(): any {
    return this.storeTransMId;
  }

  setStoreId(data: any) {
    this.storeId = data;
  }
  getStoreId(): any {
    return this.storeId;
  }

  setfromStoreAllCodesId(data: any) {
    console.log("from services",data);
    this.fromStoreAllCodesId = data;
  }
  getfromStoreAllCodesId(): any {
    console.log("from services", this.fromStoreAllCodesId)
    return this.fromStoreAllCodesId;
  }


  settoStoreAllCodesId(data: any) {
    this.toStoreAllCodesId = data;
  }
  gettoStoreAllCodesId(): any {
    console.log("from services",this.toStoreAllCodesId)
    return this.toStoreAllCodesId;
  }
}


//storeTransMaster_VM

//constructor(


//  public TrnsCode ?: number,
//  public TrnsNo ?: number,
//  public TrnsDate ?: Date,
//  public Rem ?: string,
//  public BranchId ?: number,
//  public Storedocnum ?: number,
//  public Period ?: number,
//  public FromStoreAllcodesId ?: number,
//  public ToStoreAllcodesId ?: number,
//  public StoreTrnsMId ?: number,

//)


//export class storeTransDep_VM {
//  constructor(
//    public Ptransrowid?: number,
//    public Groupid?: number,) { }
//}

//export class storeTransDepDetails_VM {
//  constructor(
//    public Depdetailsid?: number,
//    public Ctrnsorowid?: number,
//    public Ptrnsorowid?: number,

//  ) {



//StoreTransDetails_VM
//constructor(
//  public  StoreTrnsOId ?: number,
//  public  Qty ?: number,
//  public  UnitId ?: number,
//  public  UnitPrice ?: number,
//  public  DiscRate ?: number,
//  public  DiscVal ?: number,
//  public  StaxVal ?: number,
//  public  ItemCost ?: number,
//  public  TrnsPriceForcost ?: number,
//  public  StoreTrnsMId ?: number,
//  public  ItemId ?: number,
//  public  ItemKind ?: number,
//  public  Trnsods ?: number,
//  public  Unit2ndprice ?: number,
//  public  Item2nddiscRate ?: number,
//  public  Item2nddiscVal ?: number,
//  public  Totalo ?: number,
//  public  DetailCostcenterid ?: number,
//  public  DetailAccountid ?: number,
//  public  Dstid ?: number,
//  public  Commited ?: number,
//  public  Itemnotes ?: string,
//  public  Growerno ?: string,
//  public  Containerno ?: string,
//  public  Numbervalue ?: string,
//  public  Stringvalue ?: string,
//  public  Productionstageid ?: number,
//  public  StoretrnsProformlaId ?: number,
//  public  ProdformlaId ?: number,
//  public  Itemapproved ?: boolean,
//  public  Notes ?: string,
//  public  Weekno ?: number,
//  public  Fromdate ?: Data,
//  public  Todate ?: Date,
//  public  Begintime ?: Date,
//  public  Endtime ?: Date,
//  public  Safeperiod ?: number,
//  public  Poolid ?: number,
//  public  Detentionrev ?: boolean,
//  public  Releasetype ?: string,
//  public  Licenseno ?: string,
//  public  Licensedatefrom ?: Date,
//  public  Licensedateto ?: Date,
//  public  Agriageid ?: number,
//  public  Processid ?: number,
//  public  Watervolume ?: string,
//  public  Actualspace ?: string,
//  public  Waterpressure ?: string,
//  public  Purpose ?: string,
//  public  Injureid ?: number,
//  public  Phi ?: string,
//  public  Workingtime ?: number,
//  public  Restrictionperiod ?: string,
//  public  Requiredprocedure ?: string,
//  public  Injpercentage ?: string,
//  public  Fertunitid ?: number,
//  public  Agriqty ?: number,
//  public  Fromtime ?: Date,
//  public  Totime ?: Date,
//  public  Enginepressure ?: string,
//  public  Itemnetperc ?: number,
//  public  Itemtotalperc ?: number,
//  public  Distexpcost ?: number,
//  public  Agrifarmid ?: number,
//  public  Agricontainerno ?: string,
//  public  Freeitem ?: number,
//  public  UnitOldprice ?: number,
//  public  Execperc ?: number) { }
