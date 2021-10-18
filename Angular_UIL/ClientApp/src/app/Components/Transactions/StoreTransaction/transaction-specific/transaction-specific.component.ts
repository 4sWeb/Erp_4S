import { AfterContentChecked, AfterViewInit, Component, DoCheck, ElementRef, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { DataTableDirective } from 'angular-datatables';
import { from, Observable, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { MenuItem } from 'primeng/api';
import { SelectItem } from 'primeng/api';
import { SelectItemGroup } from 'primeng/api';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';
import { DialogContentDatatabelComponent } from '../dialog-content-datatabel/dialog-content-datatabel.component';
import { TransactionSpecific } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transaction-specific';
import { AllTransactions } from '../../../../models/Transactions/StoreTransaction/AllStoreTransacion/all-transactions';
import { TransactionsDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-details';
import { ToTypeDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/to-type-details';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { StoreTransMain } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-main';
import { storeTransMaster_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransMaster_VM';
import { storeTransDep_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDep_VM';
import { storeTransDepDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDepDetails_VM';
import { storeTransDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { Branches } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/Branches';
import { FromType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/from-type';
import { FromTypeDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/from-type-details';
import { ToType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/to-type';
import { SharingDataService } from '../../../../services/SharingData/sharing-data.service';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { TransactionsName } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-name';
import { Data } from 'popper.js';
import { DialogEditProductComponent } from '../dialog-edit-product/dialog-edit-product.component';
import { DialogEditStoreTransDeatailsComponent } from '../dialog-edit-store-trans-deatails/dialog-edit-store-trans-deatails.component';
import { DialogForCategoryComponent } from'../dialog-for-category/dialog-for-category.component'
import { data } from 'jquery';
import { GroupF_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupF_VM';
import { Unites_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Unites_VM';
import { Items_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Items_VM';
import { ItemDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemDetails_VM';
import { transcode } from 'buffer';
import { stringify } from 'querystring';
import { GroupItemsUnits_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupItemsUnits_VM';
import { Sales_Rep_VM } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/Sales_Rep_VM';
import { ItemsWithBalance_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemsWithBalance_VM';
import { StoreDepSpecDetails_VM } from '../../../../models/Transactions/StoreTransaction/TransactionDepSpecification/StoreDepSpecDetails_VM';

export interface DialogData {
  selectedTransaction?: number;
  checkedTransactionsIds?: number[];
  checkedTransactionsMain?: TransactionsDetails[];
}

//Dialog Edit interface
export interface DialogEdit {
  editProduct: storeTransDetails_VM;
}

export interface DialogEditStoreTransDetails {
  editStoreTransDetails: storeTransDetails_VM;
}
//Dialog For Category
export interface DialogForCategory {
  dialogCategoryDetails?: storeTransDetails_VM[];
  productdetails?: storeTransDetails_VM[];
  GroupFs: GroupItemsUnits_VM[];
  BringBalance: boolean;
  StoreId: number;
  ShowPrice: boolean;
}



@Component({
  selector: 'app-transaction-specific',
  templateUrl: './transaction-specific.component.html',
  styleUrls: ['./transaction-specific.component.css']
})
export class TransactionSpecificComponent implements OnInit, OnDestroy, DoCheck{
  constructor(public TransactionsService: TransactionsService, public SharingDataService: SharingDataService , private _router: Router,
    public ar: ActivatedRoute, public dialog: MatDialog, public dialogEdit: MatDialog
    , public dialogEditDetails: MatDialog, public dialogCaterogry: MatDialog) {
    this.storeTransMaster = { TrnsCode: 0, TrnsDate: null, TrnsNo: 0 };
  }


  TransactionSpecific: TransactionSpecific;
  AllTransactions?: AllTransactions[];
  TransactionsDetails?: TransactionsDetails[];
  TO_TypeName: string;
  From_TypeName: string;

  FromTypeLength: number;
  ToTypeLength: number;
  FromTypeDetailsLength: number;
  ToTypeDetailsLength: number;
  FromTypeTemp: FromType[]=[];
  ToTypeTemp: ToType[]=[];
  ToTypeDeailsTemp: ToTypeDetails[]=[];
  FromTypeDetailsTemp: FromTypeDetails[]=[];

  ToAllDetails?: ToTypeDetails[];
  dtOptions: DataTables.Settings[] = [];
  Sales_Rep: Sales_Rep_VM[];
  dtTrigger1: Subject<any> = new Subject();
  dtTrigger2: Subject<any> = new Subject();
  selectedTransaction: number;

  checkedTransactionsIds?: number[];
  checkedTransactionsMain?: TransactionsDetails[]=[];
  productdetails?: storeTransDetails_VM[];
  filterProduct?: storeTransDetails_VM[];
  RealProduct: storeTransDetails_VM[];

  Price: number;
  Quantity: number;

  SalesRepView: boolean=false;
  //detremine type of operation
  operationType: any;

  //Save
  StoreTransMain?: StoreTransMain;
  storeTransMaster_VM?: storeTransMaster_VM ;
  storeTransDep_VM?: storeTransDep_VM[]=[];
  storeTransDepDetails_VM?:storeTransDepDetails_VM[];
  storeTransDetails_VM?: storeTransDetails_VM[] = [];

  Branches: Branches[];
  FromType: FromType[];
  FromTypeDetails?: FromTypeDetails[];
  ToType: ToType[];
  ToTypeDetails: ToTypeDetails[];
  DepTransactionNames: TransactionsName[];
  Transcode: number = 0;
  storeTransMaster: storeTransMaster_VM;
  StoreTransDepDetailsOnly: storeTransDepDetails_VM[] = [];
  filterStoreTransDepDetails: storeTransDetails_VM[] = [];
  IsDependant?: boolean = false;
  TrnsNo: number;
  storedocnumv: number;

  //For DepSpecfication
  StoreDepSpecDetails_VM: StoreDepSpecDetails_VM;
  GetFrom: number;
  GetTo: number;
  FromFilter: number;
  ToFilter: number;
  From_TypeDep: FromType | ToType;
  To_TypeDep: ToType | FromType;
  To_TypeDetailsDep: ToTypeDetails | any;
  From_TypeDetailsDep: FromTypeDetails | any;
         //datePicker
 
  public Datevalue: Date = new Date();
  public maxDate: Date = new Date();
            ///



  //for binding
  StoreTransMId: number;
  branchId: number;
  fromStoreAllcodesId: number;
  FromTypeId: number;
  ToTypeDetailsId: number;
  ToTypeId: number;
  transDepCode: number;
  Rem: string;
  //Datevalue: Date;
  storeTransMax: number;
  salesRepId: number;
  storedocnum: number;
  transDepId: number;
  //For Edit while creating
  editProduct: DependancyProduct;

  //For Edit while Retrive(View)
  editStoreTransDetails: storeTransDetails_VM;

  //For View Details
  GroupF: GroupF_VM[];
  Items_VMs: Items_VM[];
  unites_VMs: Unites_VM[];
  itemDetails_VM: ItemDetails_VM;

  //For View Details in Second Way
  GroupFs: GroupItemsUnits_VM[];
  ItemsWithBalance: ItemsWithBalance_VM[];

  //ByMo
  ItemsAvailable: boolean = false;
  FromDistanceIsStore: boolean = false;
  StoreId: number;
  disabelCategories: boolean = true;
  QtyEffect: boolean;
  ShowPrice: boolean = false;
  //For Category Dialog
  dialogCategoryDetails: storeTransDetails_VM[];
  popupstoreTransDetails_VM: storeTransDetails_VM[]=[];


  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;



 
  ngOnInit() {

   
    this.ar.params.subscribe(
      a => {
        this.Transcode = parseInt( a['id']);
      }
    );

    console.log("Transcode", typeof (this.Transcode));
    this.Transcode =(this.Transcode) ;
    console.log("Transcode", typeof (this.Transcode));
    this.operationType = this.SharingDataService.getOperationType();
    console.log("this.operationType", this.operationType);

    this.StoreTransMId = this.SharingDataService.getStoreTransMId();
    console.log("this.StoreTransMid", this.StoreTransMId);

    this.checkedTransactionsIds = new Array<number>();
    this.checkedTransactionsMain = new Array<TransactionsDetails>();

      this.dtOptions[0] = {
        pagingType: 'full_numbers',
        pageLength: 5,
        destroy: true,
        deferRender: true,
      },
        this.dtOptions[1] = {
          pagingType: 'full_numbers',
        pageLength: 5,
        destroy: true,
        deferRender: true,
        }


    let id = 0;
    let userId = 0;
    this.ar.params.subscribe(
      a => {
        id = a['id'],
          userId = a['userId']
      }
      
    )
  
    this.TransactionsService.displayAllFieldesSpecificTransaction(id, userId).subscribe(
      (response) => {
        console.log(id);
        console.log("response", response);
        this.TransactionSpecific = response;
        console.log("this.TransactionSpecific", this.TransactionSpecific);
        if (this.TransactionSpecific.QtyEffect == false) {
          this.QtyEffect = false;
          this.disabelCategories = false;
        } else {
          this.QtyEffect = true;
        }

        //Price Effect
        if (this.TransactionSpecific.ShowPrice == 1) {
          this.ShowPrice = true;
        }

        try {
          this.Sales_Rep = this.TransactionSpecific.Sales_Rep_VM;
          if (this.Sales_Rep.length > 0) {
            this.SalesRepView = true;
          }
        }
        catch (e) { }
        try
        {
          this.FromType = this.TransactionSpecific.TransactionMasterSpec_VM.From_Type;
          var x: number = this.FromType.length;
          this.FromTypeLength = x;
              
        }
        catch (e) { this.FromTypeLength = 0; }
        try
        {
          this.ToType = this.TransactionSpecific.TransactionMasterSpec_VM.To_Type;
          var y: number = this.ToType.length;
          this.ToTypeLength=y;
        }
        catch (e) { this.ToTypeLength = 0;}

        try
        {
          this.FromTypeDetails = this.TransactionSpecific.TransactionMasterSpec_VM.FromTypeDetails;
          var z: number = this.FromTypeDetails.length;
          this.FromTypeDetailsLength=z;
        }
        catch (e) { this.FromTypeDetailsLength = 0;}

        try
        {
          this.ToTypeDetails = this.TransactionSpecific.TransactionMasterSpec_VM.ToTypeDetails;
          var b: number = this.ToTypeDetails.length;
          this.ToTypeDetailsLength = b;
        }
        catch (e) { this.ToTypeDetailsLength = 0;}
        this.Branches = this.TransactionSpecific.TransactionMasterSpec_VM.Branches;
        try
        {
          this.DepTransactionNames = this.TransactionSpecific.TransactionDepSpec_VM.TransactionsNames;
          if (this.DepTransactionNames.length>0) {
            this.IsDependant = true;
            console.log("IsDependant", this.IsDependant);
          }
        }
        catch (e) { console.log(e) };
       
        this.storeTransMax = this.TransactionSpecific.StoreTransMax;
        //need to correct
        this.storedocnum = this.TransactionSpecific.StoreTransMax;
        
        
      },
      (error) => { console.log(error); });




    if (this.operationType == "View") {
        this.TransactionsService.getTransactionByStoreTrnsMId(this.StoreTransMId).subscribe(
          (data) => {
            console.log("response2View", data);
            this.StoreTransMain = data;
            console.log("this.StoreTransMain", this.StoreTransMain);
            try {
              this.salesRepId = this.StoreTransMain.StoreTransMaster_VM.Salesrep;
            } catch (e) { console.log(e);}
            try {
              this.TrnsNo = this.StoreTransMain.StoreTransMaster_VM.TrnsNo;
              console.log("storeTransMax", this.storeTransMax);
            } catch (e) { console.log(e); }
            try {
              this.FromTypeId = this.StoreTransMain.StoreTransMaster_VM.From_Type[0].TYPE_ID;
              console.log("FromTypeId", this.FromTypeId);
            }
            catch (e) { console.log(e); };

            try {
              this.ToTypeId = this.StoreTransMain.StoreTransMaster_VM.To_Type[0].TYPE_ID;
            }
            catch (e) { console.log(e); };
            try {

                this.fromStoreAllcodesId = this.StoreTransMain.StoreTransMaster_VM.FromStoreAllcodesId;
            }
            catch (e) { console.log(e); }
            try {
              
                this.ToTypeDetailsId = this.StoreTransMain.StoreTransMaster_VM.ToStoreAllcodesId;
            }
            catch (e) { console.log(e); };

            try {
              this.branchId = this.StoreTransMain.StoreTransMaster_VM.BranchId;
              console.log("this.branchId", this.branchId);
            } catch (e) { };
            try { this.Datevalue = this.StoreTransMain.StoreTransMaster_VM.TrnsDate; } catch (e) { };
            try {this.storeTransDetails_VM = this.StoreTransMain.StoreTransDetails_VM;} catch (e) { };
            //اخر اليوم
            this.productdetails = this.StoreTransMain.StoreTransDetails_VM;
            ///
            console.log("storeTransDetails_VM", this.storeTransDetails_VM);
          
            try {
              this.storedocnumv = this.StoreTransMain.StoreTransMaster_VM.Storedocnum;
            }
            catch (e) { console.log(e); };
            try {
              this.Rem = this.StoreTransMain.StoreTransMaster_VM.Rem;
            }
            catch (e) { console.log(e); };
            //console.log("storeDocNum", this.storedocnum);

            //need to enhance as storetransDep array so transcode maybe array
            try {
              this.transDepCode = this.StoreTransMain.StoreTransDep_VM[0].trnsCode;
              this.transDepId = this.StoreTransMain.StoreTransDep_VM[0].storeTrnsDepId;
            }
            catch (e) { console.log(e); }
          
            try { this.storeTransDep_VM = this.StoreTransMain.StoreTransDep_VM;
            console.log(this.storeTransDep_VM);
              console.log("selectedTransaction", this.selectedTransaction);
            } catch (e) { console.log(e); };
            try {
              console.log("inTry");
              if (this.FromTypeId == 221 && this.QtyEffect == true && this.fromStoreAllcodesId != undefined) {
                this.FromDistanceIsStore = true;
                this.disabelCategories = false;
                console.log("LKLKLKLKLLLKL", this.FromTypeId, this.QtyEffect, this.fromStoreAllcodesId);
              } else {
                this.FromDistanceIsStore = false;
              }
            } catch (e) { }
          }
      );
     

        this.TransactionsService.getAllGroups().subscribe(
          (data) => {
            console.log("GroupF", data);
            this.GroupF = data;
          }
        );

    }
  }


  //ngAfterViewInit() {
  //  console.log("hello after view int");
  //  this.TransactionsService.GetAllItemsBalance().subscribe(
  //    res => {
  //      console.log("GetAllItemsBalance", res);
  //      this.ItemsWithBalance = res;
  //      console.log("GetAllItemsBalance", this.ItemsWithBalance);
  //    }
  //  );
  //};

  ngDoCheck() {
    console.log("hello NGDOCHEEEEEECK TransSpecific-Comp");
  
    this.GroupFs = this.TransactionsService.ShraingListOfGroupsandItems;
    if (this.TransactionsService.ListOfGroupsandItemsReady) {
      this.ItemsAvailable = true;
    };
  };




  //event handler for the select element's change event
  selectChangeHandler() {
    //Delete Previous Data
    console.log(this.FromType.length);
    console.log(this.FromTypeLength);
    console.log(this.ToType.length);
    console.log(this.ToTypeLength);
    console.log(this.FromTypeDetails.length);
    console.log(this.FromTypeDetailsLength);
    console.log(this.ToTypeDetails.length);
    console.log(this.ToTypeDetailsLength);
    this.FromTypeId =undefined;
    this.ToTypeId = undefined;
    this.fromStoreAllcodesId = undefined;
    this.ToTypeDetailsId = undefined;
    
    if (this.FromType.length > this.FromTypeLength)
    {
      console.log(this.FromType.length , this.FromTypeLength)
      try
      {
        this.FromTypeTemp = this.FromType.filter(s => s.TYPE_ID != this.From_TypeDep.TYPE_ID);
        console.log(this.FromTypeTemp);
        this.FromType = [];
        this.FromType = this.FromTypeTemp;
      } catch (e) { }

      try
      {
        this.FromTypeTemp = this.FromType.filter(s => s.TYPE_ID != this.To_TypeDep.TYPE_ID);
        console.log(this.FromTypeTemp);
        this.FromType = [];
        this.FromType = this.FromTypeTemp;
      } catch (e) { }
    
    }

    if (this.ToType.length > this.ToTypeLength)
    {
      console.log(this.ToType.length, this.ToTypeLength)
      try
      {
        this.ToTypeTemp = this.ToType.filter(s => s.TYPE_ID != this.To_TypeDep.TYPE_ID);
        console.log(this.ToTypeTemp);
        this.ToType = [];
        this.ToType = this.ToTypeTemp;
      } catch (e) { }

      try
      {
        this.ToTypeTemp = this.ToType.filter(s => s.TYPE_ID != this.From_TypeDep.TYPE_ID);
        console.log(this.ToTypeTemp);
        this.ToType = [];
        this.ToType = this.ToTypeTemp;
      } catch (e) { }

    }

    if (this.ToTypeDetails.length > this.ToTypeDetailsLength) {
      try
      {
        this.ToTypeDeailsTemp = this.ToTypeDetails.filter(s => s.StoreAllcodesId != this.To_TypeDetailsDep.StoreAllcodesId);
        this.ToTypeDetails = [];
        this.ToTypeDetails = this.ToTypeDeailsTemp;
      } catch (e) { }

      try
      {
        this.ToTypeDeailsTemp = this.ToTypeDetails.filter(s => s.StoreAllcodesId != this.From_TypeDetailsDep.StoreAllcodesId);
        this.ToTypeDetails = [];
        this.ToTypeDetails = this.ToTypeDeailsTemp;
      } catch (e) { }

    }

    if (this.FromTypeDetails.length > this.FromTypeDetailsLength)
    {
      try
      {
        this.FromTypeDetailsTemp = this.FromTypeDetails.filter(s => s.StoreAllcodesId != this.From_TypeDetailsDep.StoreAllcodesId);
        this.FromTypeDetails = [];
        this.FromTypeDetails = this.FromTypeDetailsTemp;
      } catch (e) { }

      try
      {
        this.FromTypeDetailsTemp = this.FromTypeDetails.filter(s => s.StoreAllcodesId != this.To_TypeDetailsDep.StoreAllcodesId);
        this.FromTypeDetails = [];
        this.FromTypeDetails = this.FromTypeDetailsTemp;
      } catch (e) { }
     
    }
    //update the ui
    $("#second-table").DataTable().clear().draw();

    this.selectedTransaction = this.transDepCode;

    console.log("transDepCode", this.transDepCode);
    //22-9
    this.productdetails = [];


    //Call Specification for Store Trans Dep
    var StoreDepSpec_Id: number = this.DepTransactionNames.filter(s => s.Transaction_Id == this.transDepCode)[0].StoreDepSpec_Id;
    console.log("StoreDepSpec_Id", StoreDepSpec_Id);
    this.TransactionsService.GetSpecificationForDependancy(StoreDepSpec_Id).subscribe(
      res => {
        this.StoreDepSpecDetails_VM = res;
        console.log("StoreDepSpecDetails_VM", this.StoreDepSpecDetails_VM);
        this.GetFrom = this.StoreDepSpecDetails_VM.GetFrom;
        this.GetTo = this.StoreDepSpecDetails_VM.GetTo;
        this.FromFilter = this.StoreDepSpecDetails_VM.FromFilter;
        this.ToFilter = this.StoreDepSpecDetails_VM.ToFilter;
        if (this.StoreDepSpecDetails_VM.Salesrep > 0) {
          this.SalesRepView = true;
        } else {
          this.SalesRepView = false;
        }
      }
    );
  }


  rerender(): void {
    this.dtElement.dtInstance.then((dtInstance: DataTables.Api) => {
      // Destroy the table first
      dtInstance.destroy();
      // Call the dtTrigger to rerender again
      this.TransactionsService.getTransactionsByDepID(this.selectedTransaction).subscribe(
        (response) => {
          console.log("selected id transaction",this.selectedTransaction);
          this.TransactionsDetails = response;
          console.log("selected id transaction",response)
          this.dtTrigger2.next();
        });
      this.dtTrigger2.next();
    });
  }



  openDialog(): Observable<any> {
    const dialogRef = this.dialog.open(DialogContentDatatabelComponent, {
      data: { selectedTransaction: this.selectedTransaction, checkedTransactions: this.checkedTransactionsIds }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed', result);
      //to make sure that ckecked transaction array is empty
      this.checkedTransactionsIds = [];
      this.productdetails = [];
      this.StoreTransDepDetailsOnly = [];

      if (result == null) {
        result=this.checkedTransactionsMain ;
      }

      this.checkedTransactionsMain = result;
      for (var i = 0; i < this.checkedTransactionsMain.length; i++) {
        try {

         
          this.To_TypeDep = this.checkedTransactionsMain[i].To_Type[0];
          this.TO_TypeName = this.checkedTransactionsMain[i].To_Type[0].TYPE_NAME;
          console.log(fromTypeDetailsName, fromTypeDetailsId);
        }
        catch (e) { this.TO_TypeName = "";}

        try
        {
          var fromTypeDetailsId: number;
          var fromTypeDetailsName: string;
          fromTypeDetailsId = this.checkedTransactionsMain[i].From_StoreAllcodesId;
          fromTypeDetailsName = this.checkedTransactionsMain[i].From_StoreAllcodesName;
          this.From_TypeDetailsDep = { Aname: fromTypeDetailsName, StoreAllcodesId: fromTypeDetailsId };
        } catch (e) { }

        try
        {
          var toTypeDetailsId: number;
          var toTypeDetailsName: string;
          toTypeDetailsId = this.checkedTransactionsMain[i].To_StoreAllcodesId;
          toTypeDetailsName = this.checkedTransactionsMain[i].To_StoreAllcodesName;
          this.To_TypeDetailsDep = { Aname: toTypeDetailsName, StoreAllcodesId: toTypeDetailsId }
        } catch (e) {}


        try {
          
          this.From_TypeDep = this.checkedTransactionsMain[i].From_Type[0];
          this.From_TypeName = this.checkedTransactionsMain[i].From_Type[0].TYPE_NAME;
          console.log(this.checkedTransactionsMain[i].To_StoreAllcodesId, this.checkedTransactionsMain[i].To_StoreAllcodesName);
          console.log(this.To_TypeDetailsDep);
        }
        catch (e) { this.From_TypeName = "";}
      };

      //Handle GetFrom Cases
      try
      {

        if (this.GetFrom == 1)
        {

          if (this.FromType.filter(s => s.TYPE_ID == this.From_TypeDep.TYPE_ID).length<=0)
          {
            this.FromType.push(this.From_TypeDep);
          }
          if (this.FromTypeDetails.filter(s => s.StoreAllcodesId == this.From_TypeDetailsDep.StoreAllcodesId).length<=0)
          {
            this.FromTypeDetails.push(this.From_TypeDetailsDep);
          }
          this.FromTypeId = this.From_TypeDep.TYPE_ID;
          this.fromStoreAllcodesId = this.From_TypeDetailsDep.StoreAllcodesId;
          console.log("this.FromType Try ==1", this.FromType);
          console.log("this.FromTypeDetails Try ==1", this.FromTypeDetails);
        } else if (this.GetFrom == 2)
        {

          if (this.FromType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID).length<=0)
          {
            this.FromType.push(this.To_TypeDep);
          }
          if (this.FromTypeDetails.filter(s => s.StoreAllcodesId == this.To_TypeDetailsDep.StoreAllcodesId).length<=0)
          {
            this.FromTypeDetails.push(this.To_TypeDetailsDep);
          }
          this.FromTypeId = this.To_TypeDep.TYPE_ID;
          this.fromStoreAllcodesId = this.To_TypeDetailsDep.StoreAllcodesId;
          console.log("this.ToType Try FromGet=2", this.FromType);
          console.log("this.ToTypeDetails Try FromGet=2", this.FromTypeDetails);
        }

      } catch (e)
      {
        console.log("this.ToType Catch", this.ToType);
        console.log("this.FromType Catch", this.FromType);
        console.log("this.FromTypeDetails catch", this.FromTypeDetails);
        console.log("this.ToTypeDetails Catch", this.ToTypeDetails);
      }

      //Handle GetTo Cases
      try {
        if (this.GetTo == 1)
        {
          if (this.ToType.filter(s => s.TYPE_ID == this.From_TypeDep.TYPE_ID).length<=0)
          {
            this.ToType.push(this.From_TypeDep);
          }
          if (this.ToTypeDetails.filter(s => s.StoreAllcodesId == this.From_TypeDetailsDep.StoreAllcodesId).length<=0)
          {
            this.ToTypeDetails.push(this.From_TypeDetailsDep);
          }

          this.ToTypeId = this.From_TypeDep.TYPE_ID;
          this.ToTypeDetailsId = this.From_TypeDetailsDep.StoreAllcodesId;
          console.log("this.ToType Try ==1", this.ToType);
        }
        else if (this.GetTo == 2)
        {

          if (this.ToType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID).length<=0) {
            console.log(this.ToType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID));
            this.ToType.push(this.To_TypeDep);
          }
          if (this.ToTypeDetails.filter(s => s.StoreAllcodesId == this.To_TypeDetailsDep.StoreAllcodesId).length<=0)
          {
            this.ToTypeDetails.push(this.To_TypeDetailsDep);
            
          }
          this.ToTypeId = this.To_TypeDep.TYPE_ID;
          this.ToTypeDetailsId = this.To_TypeDetailsDep.StoreAllcodesId;
          console.log("this.FromType Try ToTYPE=2", this.ToType);
          console.log("this.FromType Try  ToTYPE", this.ToTypeDetails);
        }

      } catch (e) {
        console.log("this.ToType Catch", this.ToType);
        console.log("this.FromType Catch", this.ToTypeDetails);
      }





      //Handel FromFilter

      try {

        if (this.FromFilter == 1) {

          if (this.FromType.filter(s => s.TYPE_ID == this.From_TypeDep.TYPE_ID).length <= 0) {
            this.FromType.push(this.From_TypeDep);
          }
          if (this.FromTypeDetails.filter(s => s.StoreAllcodesId == this.From_TypeDetailsDep.StoreAllcodesId).length <= 0) {
            this.FromTypeDetails.push(this.From_TypeDetailsDep);
          }
          this.FromTypeId = this.From_TypeDep.TYPE_ID;
          this.fromStoreAllcodesId = this.From_TypeDetailsDep.StoreAllcodesId;
          console.log("this.FromType Try ==1", this.FromType);
          console.log("this.FromTypeDetails Try ==1", this.FromTypeDetails);
        } else if (this.FromFilter == 2) {

          if (this.FromType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID).length <= 0) {
            this.FromType.push(this.To_TypeDep);
          }
          if (this.FromTypeDetails.filter(s => s.StoreAllcodesId == this.To_TypeDetailsDep.StoreAllcodesId).length <= 0) {
            this.FromTypeDetails.push(this.To_TypeDetailsDep);
          }
          this.FromTypeId = this.To_TypeDep.TYPE_ID;
          this.fromStoreAllcodesId = this.To_TypeDetailsDep.StoreAllcodesId;
          console.log("this.ToType Try FromGet=2", this.FromType);
          console.log("this.ToTypeDetails Try FromGet=2", this.FromTypeDetails);
        }

      } catch (e) {
        console.log("this.ToType Catch", this.ToType);
        console.log("this.FromType Catch", this.FromType);
        console.log("this.FromTypeDetails catch", this.FromTypeDetails);
        console.log("this.ToTypeDetails Catch", this.ToTypeDetails);
      }

      //Handle ToFilter Cases
      try {
        if (this.ToFilter == 1) {
          if (this.ToType.filter(s => s.TYPE_ID == this.From_TypeDep.TYPE_ID).length <= 0) {
            this.ToType.push(this.From_TypeDep);
          }
          if (this.ToTypeDetails.filter(s => s.StoreAllcodesId == this.From_TypeDetailsDep.StoreAllcodesId).length <= 0) {
            this.ToTypeDetails.push(this.From_TypeDetailsDep);
          }

          this.ToTypeId = this.From_TypeDep.TYPE_ID;
          this.ToTypeDetailsId = this.From_TypeDetailsDep.StoreAllcodesId;
          console.log("this.ToType Try ==1", this.ToType);
        }
        else if (this.ToFilter == 2) {

          if (this.ToType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID).length <= 0) {
            console.log(this.ToType.filter(s => s.TYPE_ID == this.To_TypeDep.TYPE_ID));
            this.ToType.push(this.To_TypeDep);
          }
          if (this.ToTypeDetails.filter(s => s.StoreAllcodesId == this.To_TypeDetailsDep.StoreAllcodesId).length <= 0) {
            this.ToTypeDetails.push(this.To_TypeDetailsDep);

          }
          this.ToTypeId = this.To_TypeDep.TYPE_ID;
          this.ToTypeDetailsId = this.To_TypeDetailsDep.StoreAllcodesId;
          console.log("this.FromType Try ToTYPE=2", this.ToType);
          console.log("this.FromType Try  ToTYPE", this.ToTypeDetails);
        }

      } catch (e) {
        console.log("this.ToType Catch", this.ToType);
        console.log("this.FromType Catch", this.ToTypeDetails);
      }




      for (let i = 0; i < this.checkedTransactionsMain.length; i++) {
        this.checkedTransactionsIds.push(this.checkedTransactionsMain[i].StoreTrnsMId); //use i instead of 0
      }
      console.log("From main component checkedTransactions",this.checkedTransactionsIds);
      this.TransactionsService.getAllProductDetails(this.checkedTransactionsIds).subscribe(
        (response) => {
          console.log("LOLOLOLOLOLOL");
          this.productdetails = response;
          console.log("productDetails", this.productdetails);
          try
          {
            if (this.ShowPrice == true) {
              var productFilter = this.productdetails.filter(s => s.totalo > 0);
              this.productdetails = productFilter;
            }

          } catch (e) { }
          
          console.log("productDetails", this.productdetails);
          for (var i = 0; i < this.productdetails.length; i++) {
            this.StoreTransDepDetailsOnly.push({
              groupF_Id: this.productdetails[i].groupF_Id, item_ID: this.productdetails[i].itemId,
              unitid: this.productdetails[i].unitId, quantity: this.productdetails[i].qty,
              unitPrice: this.productdetails[i].unitPrice, totalo: this.productdetails[i].totalo,
              storeTrnsOId: this.productdetails[i].storeTrnsOId,
              groupF_Name: this.productdetails[i].groupF_Name
            });
          }
          console.log("StoreTransDepDetailsOnly", this.StoreTransDepDetailsOnly);
          //to make sure that ckecked transaction array is empty
          this.checkedTransactionsIds = [];
        });
    });
    return dialogRef.afterClosed();
  }

  deleteProductRecord(i, id: number) {
    if (confirm("سيتم حذف هذا العنصر..تأكيد؟")) {
      //to delete main product if all of child item is deleted
      let count = 0;
      console.log("count", count);
      for (var j = 0; j < this.productdetails.length; j++) {
        if (this.productdetails[j].store_Trns_M_ID == id) {
          count++;
          console.log("count", count);
        }
      }
      if (count == 1) {
        console.log("count", count);
        this.checkedTransactionsMain.forEach((element, index) => {
          if (element.StoreTrnsMId == id) this.checkedTransactionsMain.splice(index, 1);
        });
      }
      this.productdetails.splice(i, 1);
      this.StoreTransDepDetailsOnly = this.productdetails.filter(s => s.storeTrnsOId > 0);
      console.log("StoreTransDepDetailsOnly after delete", this.StoreTransDepDetailsOnly);
      console.log("product after delete", this.productdetails);
    }
  }

  deleteMainRecord(i: number, id: number) {
    if (confirm("سيتم الحذف ..تأكيد؟")) {
    
      //to delete productDetails related to mainTransaction
     
      

      this.filterProduct = this.productdetails.filter(s => s.store_Trns_M_ID == id);
      this.RealProduct = this.productdetails.filter(s => s.store_Trns_M_ID != id);
      
        this.productdetails.splice(0, this.productdetails.length);

      this.productdetails = this.RealProduct;
      console.log(this.productdetails,"productdetails");
      this.checkedTransactionsMain.splice(i, 1);

      this.StoreTransDepDetailsOnly = this.productdetails.filter(s => s.storeTrnsOId > 0);
      console.log("StoreTransDepDetailsOnly after delete", this.StoreTransDepDetailsOnly);
    }

  }



  //getAllCheckedTransId(e: any,id: number) {
  //  if (e.target.checked) {
  //    console.log(id + "checked");
  //    this.checkedTransactions.push(id);
  //  } else {
  //    console.log(id + "unchecked");
  //    this.checkedTransactions = this.checkedTransactions.filter(m => m != id);
  //  }
  //  console.log(this.checkedTransactions);
  //}


  //add Store Transaction
  addStoreTransaction()
  {
    var FromAllCodes:number;
    var ToAllCodes:number;
    try {
      if (this.fromStoreAllcodesId != undefined && this.ToTypeDetailsId != undefined) //Input In From And To Done
      {
        FromAllCodes = this.fromStoreAllcodesId;
        ToAllCodes = this.ToTypeDetailsId;
    
       
        console.log(FromAllCodes);
      

      }
      else if (this.fromStoreAllcodesId != undefined && this.ToTypeDetailsId == undefined)//From Input Done But No To
      {
        FromAllCodes = this.fromStoreAllcodesId;
        ToAllCodes =null;

      }
      else if (this.fromStoreAllcodesId == undefined && this.ToTypeDetailsId != undefined) {
        ToAllCodes = this.ToTypeDetailsId;
        FromAllCodes = null;
      }
    
      else {
        ToAllCodes = null;
        FromAllCodes = null;
      }


      } catch (e) {}
    this.StoreTransMain = new StoreTransMain();
    if (this.operationType == "View") {
      this.storeTransMaster = {
        storeTrnsMId: this.StoreTransMId,
        BranchId: this.branchId,
        TrnsCode: this.Transcode,
        TrnsDate: this.Datevalue,
        TrnsNo: this.TrnsNo,
        FromStoreAllcodesId: FromAllCodes,
        ToStoreAllcodesId: ToAllCodes,
        Period: 2,
        Rem: this.Rem,
        Storedocnum: this.storedocnumv,
        Salesrep: this.salesRepId,
      };

      this.storeTransDep_VM = this.editTransaction();
      alert(` تم تعديل حركة ${this.TransactionSpecific.Aname} برقم ${this.TrnsNo} `);
    }
    else {
      this.storeTransMaster = {
        storeTrnsMId: 0,
        BranchId: this.branchId,
        TrnsCode: this.Transcode,
        TrnsDate: this.Datevalue,
        TrnsNo: this.storeTransMax,
        FromStoreAllcodesId: FromAllCodes,
        ToStoreAllcodesId: ToAllCodes,
        Period: 2,
        Rem: this.Rem,
        Storedocnum: this.storedocnum,
        Salesrep: this.salesRepId,
      };
      this.storeTransDep_VM = this.fillStoreTranDep();
      alert(` تم اضافة حركة ${this.TransactionSpecific.Aname} برقم ${this.storeTransMax} `);

    }
   
   
 
    this.StoreTransMain.StoreTransMaster_VM = this.storeTransMaster;
    console.log("storeTransMaster_VM", this.StoreTransMain.StoreTransMaster_VM);

    this.StoreTransMain.StoreTransDetails_VM = this.productdetails;

    
   
    this.StoreTransMain.StoreTransDep_VM = this.storeTransDep_VM;
    console.log("storeTransDep_VM", this.storeTransDep_VM);


    this.filterStoreTransDepDetails = this.productdetails.filter(s => s.storeTrnsOId > 0);
    this.StoreTransDepDetailsOnly = [];
    for (var i = 0; i < this.filterStoreTransDepDetails.length; i++) {
      //NEED TO CHECK IF QUANTITY NOT EQUAL ZERO
      if (this.filterStoreTransDepDetails[i].totalo > 0) {
        console.log("enter");
        this.StoreTransDepDetailsOnly.push({
          itemid: this.filterStoreTransDepDetails[i].itemId,
          unitid: this.filterStoreTransDepDetails[i].unitId,
          groupF_Id: this.filterStoreTransDepDetails[i].groupF_Id,
          quantity: this.filterStoreTransDepDetails[i].qty,
          unitPrice: this.filterStoreTransDepDetails[i].unitPrice,
          totalo: this.filterStoreTransDepDetails[i].totalo,
          //prowId: this.filterStoreTransDepDetails[i].store_Trns_M_ID,
          commited: 0
        });
      }
    }

    this.StoreTransMain.StoreTransDepDetails_VM = this.StoreTransDepDetailsOnly;
    console.log("storeTransDepDetails_VM", this.StoreTransMain.StoreTransDepDetails_VM);


    this.StoreTransMain.StoreTransDetails_VM = this.productdetails;

    //Which price will be Saved

    this.storeTransDetails_VM = this.StoreTransMain.StoreTransDetails_VM;
    console.log("storeTransDetails_VM", this.storeTransDetails_VM);

    this.StoreTransMain.IsDependant = this.IsDependant;
    this.TransactionsService.CreateTransaction(this.StoreTransMain).subscribe(
      (ews) => {
        console.log(ews, this.StoreTransMain);
       
      },
      (error) => { console.log(error, this.StoreTransMain); }
    )
    this._router.navigate([`/all-transactions/${this.Transcode}`]);
  }

  selectFromDetailsChange(FromDetailsValue: number) {
    this.fromStoreAllcodesId = FromDetailsValue;

  }

  //open EditDialog
  EditProduct(EditPro): void {
    this.editProduct = EditPro;
    console.log(this.editProduct);
    const dialogReff = this.dialogEdit.open(DialogEditProductComponent, {
      
      width: '350px',
      data: { editProduct: this.editProduct }
    });
    dialogReff.afterClosed().subscribe(result => {
      console.log('From spec compenent The Edit dialog was closed', result);
      

      if (result == null) {
        result = this.editProduct;
      }

      return dialogReff.afterClosed();
    });
    
  };

  
  // open EditStoreTransDetailsDialog While Retrieve(View)
  EditDetails(EditDetail) {
    this.editStoreTransDetails = EditDetail;
    console.log(this.editStoreTransDetails);
    const dialogReff = this.dialogEdit.open(DialogEditStoreTransDeatailsComponent, {

      width: '350px',
      data: { editStoreTransDetails: this.editStoreTransDetails }
    });
    dialogReff.afterClosed().subscribe(result => {
      console.log('From spec compenent The EditStoreTransDetailsDialog was closed', result);


      if (result == null) {
        result = this.editStoreTransDetails;
      }

      return dialogReff.afterClosed();
    });

  };

  //open CategoryDialog
  openCategoryDialog(): void {
    console.log("in open dialog method", this.productdetails);
    this.StoreId = this.fromStoreAllcodesId;
    //this.productdetails = [];
    var temp = this.productdetails;
    console.log("temp",temp);
    if (this.productdetails == undefined) {
      this.productdetails = [];
    }
    console.log("temp", temp);
    console.log("FromDistanceIsStore from spesc componenet", this.FromDistanceIsStore);
    const dialogReff = this.dialogEdit.open(DialogForCategoryComponent, {
      data: { dialogCategoryDetails: this.dialogCategoryDetails, productdetails: this.productdetails, GroupFs: this.GroupFs, BringBalance: this.FromDistanceIsStore, ItemsWithBalance: this.ItemsWithBalance, StoreId: this.StoreId, ShowPrice: this.ShowPrice }
      
    });
    dialogReff.afterClosed().subscribe(result => {
      console.log("specific close", result);
      if (result == undefined && temp != undefined) {
        result = temp;
      } else if (result == undefined && temp == undefined) {
        result = [];
      }
      this.dialogCategoryDetails = result;
      console.log(this.dialogCategoryDetails);
      //for (var i = 0; i < result.length; i++) {
      //  if (this.dialogCategoryDetails[i].itemId != 0
      //    && this.dialogCategoryDetails[i].unitId != 0
      //    && this.dialogCategoryDetails[i].totalo != 0
      //    && this.dialogCategoryDetails[i].qty != 0
      //    && this.dialogCategoryDetails[i].unitPrice != 0)
      //  {
      //    this.popupstoreTransDetails_VM.push(this.dialogCategoryDetails[i]);
      //  }
      // // console.log("storeTransDetails_VM",this.storeTransDetails_VM);

      //}
      this.popupstoreTransDetails_VM = this.dialogCategoryDetails;
      console.log('From spec compenent The Category Dialog was closed', this.popupstoreTransDetails_VM);
      this.productdetails = this.popupstoreTransDetails_VM;
      this.storeTransDetails_VM = this.productdetails;
      console.log("storeTransDetails_VM", this.storeTransDetails_VM);



      ////depdetails

      this.filterStoreTransDepDetails = this.productdetails.filter(s => s.storeTrnsOId > 0);
      this.StoreTransDepDetailsOnly = [];
      for (var i = 0; i < this.filterStoreTransDepDetails.length; i++) {

        this.StoreTransDepDetailsOnly.push({
          item_ID: this.filterStoreTransDepDetails[i].itemId,
          unitid: this.filterStoreTransDepDetails[i].unitId,
          groupF_Id: this.filterStoreTransDepDetails[i].groupF_Id,
          quantity: this.filterStoreTransDepDetails[i].qty,
          unitPrice: this.filterStoreTransDepDetails[i].unitPrice,
          totalo: this.filterStoreTransDepDetails[i].totalo,
         // prowId: this.filterStoreTransDepDetails[i].store_Trns_M_ID,
          commited:0
        });
      }


    console.log("this.StoreTransDepDetailsOnly", this.StoreTransDepDetailsOnly);

      if (result == null) {
        //result = this.editProduct;
      }

      return dialogReff.afterClosed();
    });
  };

  FromDistChange(event: any) {
    console.log("FromDistChange");
    console.log("FromDistChange", event);
    try { console.log(this.fromStoreAllcodesId); } catch (e) {}
    console.log(this.QtyEffect);
    try {
      if (event == 221 && this.QtyEffect == true && this.fromStoreAllcodesId != undefined) {
        this.FromDistanceIsStore = true;
        this.disabelCategories = false;
      } else {
        this.FromDistanceIsStore = false;
      }
    } catch (e) {}
    
  }

  FromDistDetailsChange(event: any) {
    console.log("FromDistDetailsChange");
    console.log("FromDistDetailsChange", event);
    console.log("FromDistDetailsChange", this.QtyEffect);
    try { console.log(this.FromTypeId); } catch (e) { };
    try {
      if (this.FromTypeId == 221 && this.QtyEffect == true && event != undefined) {
        console.log(this.FromTypeId, this.QtyEffect, event);
        this.disabelCategories = false;
        this.FromDistanceIsStore = true;
      } else {
        this.FromDistanceIsStore = false;
      }
    } catch (e) {}

  }


  GroupfChange(id: number, i: number) {

    this.TransactionsService.getItemsDetails(id).subscribe(
      (data) => {
        console.log("iiiiiiiiiiiiiiiiiiiiiiiiiiiiii", i);
        this.itemDetails_VM = data;
        this.Items_VMs = this.itemDetails_VM.items_VM;
        this.unites_VMs = this.itemDetails_VM.unites_VM;
        this.storeTransDetails_VM[0].itemId = this.itemDetails_VM.items_VM[0].ITEM_ID;
        this.storeTransDetails_VM[0].unitId = this.itemDetails_VM.unites_VM[0].UNIT_ID;
      }
    );
  };

  ItemsChange(id: number) {
    this.TransactionsService.getUnitesDetails(id).subscribe(
      (data) => {
        console.log("unites",data);
        this.unites_VMs = data;
        this.storeTransDetails_VM[0].unitId = this.unites_VMs[0].UNIT_ID;
      }
    )

  };

  deleteTransaction(StoreTransMId: number) {

    console.log("clicked");
    if (confirm("تأكيــد عملية الحذف")) {
            StoreTransMId = this.StoreTransMId;
            console.log(StoreTransMId);
            this.TransactionsService.DeleteTransaction(StoreTransMId).subscribe(
              (res) => { console.log("Delet", res); }
              ,
              (error) => { console.log(error); }
      );
      this._router.navigate([`/all-transactions/${this.Transcode}`]);
    }

  };

  editTransaction(): storeTransDep_VM[] {
    try {
      if (this.checkedTransactionsMain.length > 0) {
        this.fillStoreTranDep();
      }
     
    } catch (e) {
      this.storeTransDep_VM = this.StoreTransMain.StoreTransDep_VM;};
    return this.storeTransDep_VM;
  };

  fillStoreTranDep(): storeTransDep_VM[] {
    console.log("بدأت");
    for (var i = 0; i < this.checkedTransactionsMain.length; i++) {
      this.storeTransDep_VM.push({
        ptransrowid: this.checkedTransactionsMain[i].StoreTrnsMId,
        branchId: this.checkedTransactionsMain[i].BranchId,
      });
      return this.storeTransDep_VM;
    };
    console.log("خلصت");
  };

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    //this.dtTrigger1.unsubscribe();
    //this.dtTrigger2.unsubscribe();
  }
}
