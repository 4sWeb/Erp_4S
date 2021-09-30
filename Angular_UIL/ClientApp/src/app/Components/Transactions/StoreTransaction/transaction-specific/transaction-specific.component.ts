import { AfterViewInit, Component, DoCheck, ElementRef, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
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
  GroupFs: GroupF_VM[];

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
    this.storeTransMaster = { trnsCode: 0, trnsDate: null, trnsNo: 0 };
  }
    
    

  TransactionSpecific: TransactionSpecific;
  AllTransactions?: AllTransactions[];
  TransactionsDetails?: TransactionsDetails[];
  ToAllDetails?: ToTypeDetails[];
  dtOptions: DataTables.Settings[] = [];
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

  //detremine type of operation
  operationType: any;

  //Save
  StoreTransMain?: StoreTransMain;
  storeTransMaster_VM?: storeTransMaster_VM ;
  storeTransDep_VM?: storeTransDep_VM[]=[];
  storeTransDepDetails_VM?:storeTransDepDetails_VM[];
  storeTransDetails_VM?: storeTransDetails_VM[]=[];
  Branches: Branches[];
  FromType: FromType[];
  FromTypeDetails: FromTypeDetails[];
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
  GroupFs: GroupF_VM[];

  //ByMo
  ItemsAvailable: boolean= false;

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
        this.FromTypeDetails = this.TransactionSpecific.TransactionMasterSpec_VM.FromTypeDetails;
        this.FromType = this.TransactionSpecific.TransactionMasterSpec_VM.From_Type;
        this.ToTypeDetails = this.TransactionSpecific.TransactionMasterSpec_VM.ToTypeDetails;
        this.Branches = this.TransactionSpecific.TransactionMasterSpec_VM.Branches;
        try {
          this.DepTransactionNames = this.TransactionSpecific.TransactionDepSpec_VM.TransactionsNames;
          if (this.DepTransactionNames.length>0) {
            this.IsDependant = true;
            console.log("IsDependant", this.IsDependant);
          }
        } catch (e) { console.log(e) };
        this.ToType = this.TransactionSpecific.TransactionMasterSpec_VM.To_Type;
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
            console.log("this.StoreTransMain",this.StoreTransMain);
            try {
              this.TrnsNo = this.StoreTransMain.storeTransMaster_VM.trnsNo;
              console.log("storeTransMax", this.storeTransMax);
            } catch (e) { }
            try {
              console.log("FromTypeId");
              this.FromTypeId = this.StoreTransMain.storeTransMaster_VM.from_Type[0].TYPE_ID;
              console.log("FromTypeId", this.FromTypeId);
            }
            catch (e) { console.log(e); };

            try {
              this.ToTypeId = this.StoreTransMain.storeTransMaster_VM.to_Type[0].TYPE_ID;
            }
            catch (e) { console.log(e); };
            try {

                this.fromStoreAllcodesId = this.StoreTransMain.storeTransMaster_VM.fromStoreAllcodesId;
            }
            catch (e) { console.log(e); }
            try {
              
                this.ToTypeDetailsId = this.StoreTransMain.storeTransMaster_VM.toStoreAllcodesId;
            }
            catch (e) { console.log(e); };

            this.branchId = this.StoreTransMain.storeTransMaster_VM.branchId;
            this.Datevalue = this.StoreTransMain.storeTransMaster_VM.trnsDate;
            this.storeTransDetails_VM = this.StoreTransMain.storeTransDetails_VM;
            //اخر اليوم
            this.productdetails = this.StoreTransMain.storeTransDetails_VM;
            ///
            console.log("storeTransDetails_VM", this.storeTransDetails_VM);
          
            try {
              this.storedocnumv = this.StoreTransMain.storeTransMaster_VM.storedocnum;
            }
            catch (e) { console.log(e); };
            try {
              this.Rem = this.StoreTransMain.storeTransMaster_VM.rem;
            }
            catch (e) { console.log(e); };
            //console.log("storeDocNum", this.storedocnum);

            //need to enhance as storetransDep array so transcode maybe array
            try {
              this.transDepCode = this.StoreTransMain.storeTransDep_VM[0].trnsCode;
              this.transDepId = this.StoreTransMain.storeTransDep_VM[0].storeTrnsDepId;
            }
            catch (e) { console.log(e); }
          
            this.storeTransDep_VM = this.StoreTransMain.storeTransDep_VM;
            console.log(this.storeTransDep_VM);
            console.log("selectedTransaction",this.selectedTransaction);
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
  //  //this.TransactionsService.GetAllGroupsWithItemsDetails().subscribe(
  //  //  res => {
  //  //    console.log("GetAllGroupsWithItemsDetails", res);
  //  //    this.GroupFs = res;
  //  //    this.ItemsAvailable = true;
  //  //  }
  //  //);
  //  console.log("@@@@@@@@@@@@@@@@", this.TransactionsService.ShraingListOfGroupsandItems)
  //  this.GroupFs = this.TransactionsService.ShraingListOfGroupsandItems;
  //  console.log("Items available in GrpFs", this.GroupFs)
  //  this.ItemsAvailable = true;
      
  //};

  ngDoCheck() {
    console.log("hello NGDOCHEEEEEECK TransSpecific-Comp");
  
    this.GroupFs = this.TransactionsService.ShraingListOfGroupsandItems;
    if (this.TransactionsService.ListOfGroupsandItemsReady) {
      this.ItemsAvailable = true;
    }
    
  }



  //event handler for the select element's change event
  selectChangeHandler() {
    //update the ui
    $("#second-table").DataTable().clear().draw();

    this.selectedTransaction = this.transDepCode;

    console.log(this.selectedTransaction);
    console.log("transDepCode", this.transDepCode);
    //22-9
    this.productdetails = [];
    //
    this.TransactionsService.getTransactionsByDepID(this.transDepCode).subscribe(
      (response) => {
        console.log("selected id transaction", this.transDepCode);
        this.TransactionsDetails = response;
        this.rerender();
        console.log("selected id transaction", response)
        this.dtTrigger2.next();
      });
    this.rerender();
    this.dtTrigger2.next();
   // $("#my_select").data("default-value", $("#my_select").val());
   // $('#my_select').val('...');
   // this.rerender();
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

      if (result == null) {
        result=this.checkedTransactionsMain ;
      }

      this.checkedTransactionsMain = result;
      for (let i = 0; i < this.checkedTransactionsMain.length; i++) {
        this.checkedTransactionsIds.push(this.checkedTransactionsMain[i].StoreTrnsMId); //use i instead of 0
      }
      console.log("From main component checkedTransactions",this.checkedTransactionsIds);
      this.TransactionsService.getAllProductDetails(this.checkedTransactionsIds).subscribe(
        (response) => {
          console.log("LOLOLOLOLOLOL");
          this.productdetails = response;
          var productFilter = this.productdetails.filter(s => s.totalo > 0);
          this.productdetails = productFilter;
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
      alert(this.ToTypeDetailsId);
      alert(this.fromStoreAllcodesId);
      if (this.fromStoreAllcodesId != undefined && this.ToTypeDetailsId != undefined) //Input In From And To Done
      {
        FromAllCodes = this.fromStoreAllcodesId;
        ToAllCodes = this.ToTypeDetailsId;
        console.log("11111111111111");
       
        console.log(FromAllCodes);
        console.log("////////////", ToAllCodes);

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
        branchId: this.branchId,
        trnsCode: this.Transcode,
        trnsDate: this.Datevalue,
        trnsNo: this.TrnsNo,
        fromStoreAllcodesId: FromAllCodes,
        toStoreAllcodesId: ToAllCodes,
        period: 2,
        rem: this.Rem,
        storedocnum: this.storedocnumv
      };

      this.storeTransDep_VM = this.editTransaction();
    }
    else {
      this.storeTransMaster = {
        storeTrnsMId: 0,
        branchId: this.branchId,
        trnsCode: this.Transcode,
        trnsDate: this.Datevalue,
        trnsNo: this.storeTransMax,
        fromStoreAllcodesId: FromAllCodes,
        toStoreAllcodesId: ToAllCodes,
        period: 2,
        rem: this.Rem,
        storedocnum: this.storedocnum
      };
      this.storeTransDep_VM= this.fillStoreTranDep();

    }
   
   
 
    this.StoreTransMain.storeTransMaster_VM = this.storeTransMaster;
    console.log("storeTransMaster_VM", this.StoreTransMain.storeTransMaster_VM);

    this.StoreTransMain.storeTransDetails_VM = this.productdetails;

    
   
    this.StoreTransMain.storeTransDep_VM = this.storeTransDep_VM;
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

    this.StoreTransMain.storeTransDepDetails_VM = this.StoreTransDepDetailsOnly;
    console.log("storeTransDepDetails_VM", this.StoreTransMain.storeTransDepDetails_VM);


    this.StoreTransMain.storeTransDetails_VM = this.productdetails;
    this.storeTransDetails_VM = this.StoreTransMain.storeTransDetails_VM;
    console.log("storeTransDetails_VM", this.storeTransDetails_VM);

    this.StoreTransMain.isDependant = this.IsDependant;
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
    console.log("in open dialog method",this.productdetails);
    //this.productdetails = [];
    var temp = this.productdetails;
    console.log("temp",temp);
    if (this.productdetails == undefined) {
      this.productdetails = [];
    }
    console.log("temp", temp);
    const dialogReff = this.dialogEdit.open(DialogForCategoryComponent, {
      data: { dialogCategoryDetails: this.dialogCategoryDetails, productdetails: this.productdetails, GroupFs: this.GroupFs }
      
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

  GroupfChange(id: number, i: number) {

    this.TransactionsService.getItemsDetails(id).subscribe(
      (data) => {
        console.log("iiiiiiiiiiiiiiiiiiiiiiiiiiiiii", i);
        this.itemDetails_VM = data;
        this.Items_VMs = this.itemDetails_VM.items_VM;
        this.unites_VMs = this.itemDetails_VM.unites_VM;
        this.storeTransDetails_VM[0].itemId = this.itemDetails_VM.items_VM[0].itemId;
        this.storeTransDetails_VM[0].unitId = this.itemDetails_VM.unites_VM[0].uniteId;
      }
    );
  };

  ItemsChange(id: number) {
    this.TransactionsService.getUnitesDetails(id).subscribe(
      (data) => {
        console.log("unites",data);
        this.unites_VMs = data;
        this.storeTransDetails_VM[0].unitId = this.unites_VMs[0].uniteId;
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
      this.storeTransDep_VM = this.StoreTransMain.storeTransDep_VM;};
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
    this.dtTrigger1.unsubscribe();
    this.dtTrigger2.unsubscribe();
  }
}
