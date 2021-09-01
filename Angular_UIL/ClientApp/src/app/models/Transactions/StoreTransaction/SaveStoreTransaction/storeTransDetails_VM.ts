import { Data } from "@angular/router";

export class storeTransDetails_VM {
  constructor(
    //need to save 
    public storeTrnsOId ?:number,  
    public qty?:number,
    public unitId?: number,
    public unit_Name?: string,
    public unitPrice?: number,
    public storetrnsProformlaId?: number,
    public item2nddiscVal?: number,
    public agriqty?: number,
    public discVal?: number,
    public itemapproved?: boolean,
    public notes?: string,
    public itemCost?: number,
    public itemKind?: number,
    public itemId?: number,
    public unitOldprice?: number,
    public staxVal?: number,
    public todate?: Date, 
    public storeTrnsMId?: number,
    public weekno?: number,
    public totalo?: number,
    //End of  need to save
    public item_Name?: string,
    
        public  Trnsods?: number,
        public  Unit2ndprice?: number,
   
    
        public  DetailCostcenterid?:number ,
        public  DetailAccountid ?:number ,
        public  Dstid?:number ,
        public  Commited?:number ,
        public  Itemnotes?:string  ,  
        public  Growerno?:string  ,  
        public  Containerno?:string,   
        public  Numbervalue?:string,   
        public  Stringvalue?:string,   
        public  Productionstageid?:number,  
    
        public  ProdformlaId?: number,
               
    
    
        public  Fromdate?: Data,    
        
        public  Begintime?:Date,     
        public  Endtime?:Date,     
        public  Safeperiod?:number,      
        public  Poolid?: number,
        public  Detentionrev?: boolean, 
        public  Releasetype?:string,  
        public  Licenseno?:string,       
        public  Licensedatefrom?:Date,
        public  Licensedateto?:Date,
        public  Agriageid?:number, 
        public  Processid?:number, 
        public  Watervolume?:string,   
        public  Actualspace?:string ,  
        public  Waterpressure?:string ,  
        public  Purpose?: string,
        public  Injureid?: number, 
        public  Phi?: string,
        public  Workingtime?: number, 
        public  Restrictionperiod?: string,    
        public  Requiredprocedure?: string,    
        public  Injpercentage?: string,   
        public  Fertunitid?:number,
    
        public  Fromtime?:Date,
        public  Totime?:Date,
        public  Enginepressure?:string,    
        public  Itemnetperc?:number, 
        public  Itemtotalperc?:number, 
        public  Distexpcost?:number, 
        public  Agrifarmid?:number, 
        public  Agricontainerno?:string,    
        public  Freeitem?:number,
    
    public Execperc?: number,
    public TrnsPriceForcost?: number,
    public Item2nddiscRate?: number,
    public DiscRate?: number,
  ) { }
}

