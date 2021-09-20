import { AfterViewInit, Component, ElementRef, OnChanges, OnDestroy, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
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
export class TransactionSpecificComponent implements OnInit, OnDestroy,AfterViewInit{
  constructor(public TransactionsService: TransactionsService, public SharingDataService: SharingDataService,
    public ar: ActivatedRoute, public dialog: MatDialog, public dialogEdit: MatDialog
    , public dialogEditDetails: MatDialog, public dialogCaterogry: MatDialog) { }
    
    

  TransactionSpecific: TransactionSpecific;
  AllTransactions?: AllTransactions[];
  TransactionsDetails?: TransactionsDetails[];
  ToAllDetails?: ToTypeDetails[];
  dtOptions: DataTables.Settings[] = [];
  dtTrigger1: Subject<any> = new Subject();
  dtTrigger2: Subject<any> = new Subject();
  selectedTransaction: number;

  checkedTransactionsIds?: number[];
  checkedTransactionsMain?: TransactionsDetails[];
  productdetails?: storeTransDetails_VM[];

  Price: number;
  Quantity: number;

  //detremine type of operation
  operationType: any;

  //Save
  StoreTransMain?: StoreTransMain;
  storeTransMaster_VM?: storeTransMaster_VM;
  storeTransDep_VM?: storeTransDep_VM[];
  storeTransDepDetails_VM?:storeTransDepDetails_VM[];
  storeTransDetails_VM?: storeTransDetails_VM[]=[];
  Branches: Branches[];
  FromType: FromType[];
  FromTypeDetails: FromTypeDetails[];
  ToType: ToType[];
  ToTypeDetails: ToTypeDetails[];
  DepTransactionNames: TransactionsName[];


         //datePicker
  public today: Date = new Date();
  public currentYear: number = this.today.getFullYear();
  public currentMonth: number = this.today.getMonth();
  public currentDay: number = this.today.getDate();
  public currentHour: number = this.today.getHours();
  public currentMinute: number = this.today.getMinutes();
  public currentSecond: number = this.today.getSeconds();
  public Datevalue: Date = new Date(new Date().setDate(14));
            ///



  //for binding
  StoreTransMId: number;
  branchId: number;
  fromStoreAllcodesId: number;
  FromTypeId: number;
  ToTypeDetailsId: number;
  ToTypeId: number;
  TransCode: number;
  Rem: string;
  //Datevalue: Date;
  storeTransMax: number;
  storedocnum: number;
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

  //For Category Dialog
  dialogCategoryDetails: storeTransDetails_VM[];
  popupstoreTransDetails_VM: storeTransDetails_VM[]=[];


  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;



 
  ngOnInit() {
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
        this.DepTransactionNames = this.TransactionSpecific.TransactionDepSpec_VM.TransactionsNames;
        this.ToType = this.TransactionSpecific.TransactionMasterSpec_VM.To_Type;
        this.storeTransMax = this.TransactionSpecific.StoreTransMax;
        //need to correct
        this.storedocnum = this.TransactionSpecific.StoreTransMax;
        
        
      },
      (error) => { console.log(error); });




    if (this.operationType == "View") {
        this.TransactionsService.getTransactionByStoreTrnsMId(this.StoreTransMId).subscribe(
          (data) => {
            console.log("response2", data);
            this.StoreTransMain = data;
            console.log("*******************",this.StoreTransMain);
            this.fromStoreAllcodesId = this.StoreTransMain.storeTransMaster_VM.fromStoreAllcodesId;
            this.ToTypeDetailsId = this.StoreTransMain.storeTransMaster_VM.toStoreAllcodesId;
            this.branchId = this.StoreTransMain.storeTransMaster_VM.branchId;
            this.Datevalue = this.StoreTransMain.storeTransMaster_VM.trnsDate;
 

            //console.log("transDepCode", this.TransCode);
            this.FromTypeId = this.StoreTransMain.storeTransMaster_VM.from_Type[0].TYPE_ID;
            this.ToTypeId = this.StoreTransMain.storeTransMaster_VM.to_Type[0].TYPE_ID;
            this.storeTransMax = this.StoreTransMain.storeTransMaster_VM.storeTransMax;
            this.storedocnum = this.StoreTransMain.storeTransMaster_VM.storedocnum;
            console.log("storeDocNum", this.storedocnum);

            this.storeTransDetails_VM = this.StoreTransMain.storeTransDetails_VM;
            console.log("storeTransDetails_VM", this.storeTransDetails_VM);
            this.itemDetails_VM = this.StoreTransMain.storeTransDetails_VM[0].itemDetails_VM;
            this.Items_VMs = this.StoreTransMain.storeTransDetails_VM[0].itemDetails_VM.items_VM;
            this.unites_VMs = this.StoreTransMain.storeTransDetails_VM[0].itemDetails_VM.unites_VM;
            //need to enhance as storetransDep array so transcode maybe array
            this.TransCode = this.StoreTransMain.storeTransDep_VM[0].trnsCode;
          
            this.storeTransDep_VM = this.StoreTransMain.storeTransDep_VM;
           
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


  ngAfterViewInit() {
    console.log("hello after view int");
    this.TransactionsService.GetAllGroupsWithItemsDetails().subscribe(
      res => {
        console.log("GetAllGroupsWithItemsDetails", res);
        this.GroupFs = res;
      }
    );
      
  }


  //ngAfterViewInit(): void {
  //  if (this.operationType == "View") {
  //    this.TransactionsService.getTransactionByStoreTrnsMId(this.StoreTransMId).subscribe(
  //      (data) => {
  //        console.log("response2", data);
  //        this.StoreTransMain = data;
  //        console.log(this.StoreTransMain);
  //        this.fromStoreAllcodesId = this.StoreTransMain.storeTransMaster_VM.fromStoreAllcodesId;
  //        this.ToTypeDetailsId = this.StoreTransMain.storeTransMaster_VM.toStoreAllcodesId;
  //        this.branchId = this.StoreTransMain.storeTransMaster_VM.branchId;
  //        this.Datevalue = this.StoreTransMain.storeTransMaster_VM.trnsDate;
  //        //need to enhance as storetransDep array so transcode maybe array
  //        this.TransCode = this.StoreTransMain.storeTransDep_VM[0].trnsCode;
  //        console.log("storeTransDepId", this.TransCode);
  //        this.FromTypeId = this.StoreTransMain.storeTransMaster_VM.from_Type[0].TYPE_ID;
  //        this.ToTypeId = this.StoreTransMain.storeTransMaster_VM.to_Type[0].TYPE_ID;
  //        this.storeTransMax = this.StoreTransMain.storeTransMaster_VM.storeTransMax;
  //        this.storedocnum = this.StoreTransMain.storeTransMaster_VM.storedocnum;
  //        console.log("storeDocNum", this.storedocnum);
  //        this.storeTransDep_VM = this.StoreTransMain.storeTransDep_VM;
  //        this.storeTransDetails_VM = this.StoreTransMain.storeTransDetails_VM;

  //      }
  //    );
  //    this.TransactionsService.getAllGroups().subscribe(
  //      (data) => {
  //        console.log("GroupF", data);
  //        this.GroupF = data;
  //      }
  //    );

  //  }



  //  let id = 0;
  //  let userId = 0;
  //  this.ar.params.subscribe(
  //    a => {
  //      id = a['id'],
  //        userId = a['userId']
  //    }
  //  )
  //  this.TransactionsService.displayAllFieldesSpecificTransaction(id, userId).subscribe(
  //    (response) => {
  //      console.log(id);
  //      this.AllTransactions = response.TransactionDepSpec.TrnsList;
  //      console.log(this.selectedTransaction);
  //      this.dtTrigger1.next();
  //  });
  //}


  //event handler for the select element's change event
  selectChangeHandler() {
    //update the ui
    $("#second-table").DataTable().clear().draw();

    this.selectedTransaction = this.TransCode;

    console.log(this.selectedTransaction);
    console.log("TransCode", this.TransCode);
    this.TransactionsService.getTransactionsByDepID(this.TransCode).subscribe(
      (response) => {
        console.log("selected id transaction", this.TransCode);
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



  //openDialog() {
  //  //const dialogRef = this.dialog.open(DialogContentDatatabelComponent);

  //  const dialogConfig = new MatDialogConfig();
  //  dialogConfig.disableClose = true;
  //  dialogConfig.autoFocus = true;

  //  dialogConfig.data = {
  //    selectedTransaction: this.selectedTransaction,
  //  };
  //  console.log("from open dialog",this.selectedTransaction);

  //  this.dialog.open(DialogContentDatatabelComponent, dialogConfig);

  //  //dialogRef.afterClosed().subscribe(result => {
  //  //  console.log(`Dialog result: ${result}`);
  //  //});
  //}
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
          console.log("productDetails", this.productdetails);
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
      for (let j = 0; j < this.productdetails.length; j++) {
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
      console.log("product after delete", this.productdetails);
    }
  }

  deleteMainRecord(i, id: number) {
    if (confirm("سيتم الحذف ..تأكيد؟")) {
      console.log("mainRecordId", id);
      this.checkedTransactionsMain.splice(i, 1);
      console.log("this.checkedTransactionsMain", this.checkedTransactionsMain);
      //to delete productDetails related to mainTransaction
      for (let j = 0; j < this.productdetails.length; j++) {
        if (this.productdetails[j].store_Trns_M_ID == id) {
          this.productdetails.splice(j, 1);
        }
      }
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
  addStoreTransaction() {

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
    if (this.productdetails == undefined) {
      this.productdetails = [];
    }
    const dialogReff = this.dialogEdit.open(DialogForCategoryComponent, {
      data: { dialogCategoryDetails: this.dialogCategoryDetails, productdetails: this.productdetails, GroupFs: this.GroupFs }
      
    });
    dialogReff.afterClosed().subscribe(result => {
      this.dialogCategoryDetails = result;
      console.log(this.dialogCategoryDetails);
      for (var i = 0; i < result.length; i++) {
        if (this.dialogCategoryDetails[i].itemId != 0
          && this.dialogCategoryDetails[i].unitId != 0
          && this.dialogCategoryDetails[i].totalo != 0
          && this.dialogCategoryDetails[i].qty != 0
          && this.dialogCategoryDetails[i].unitPrice != 0)
        {
          this.popupstoreTransDetails_VM.push(this.dialogCategoryDetails[i]);
        }
       // console.log("storeTransDetails_VM",this.storeTransDetails_VM);

      }
      console.log('From spec compenent The Category Dialog was closed', this.popupstoreTransDetails_VM);
      this.productdetails = this.popupstoreTransDetails_VM;
      console.log("storeTransDetails_VM", this.popupstoreTransDetails_VM);
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
  }

  ItemsChange(id: number) {
    this.TransactionsService.getUnitesDetails(id).subscribe(
      (data) => {
        console.log("unites",data);
        this.unites_VMs = data;
        this.storeTransDetails_VM[0].unitId = this.unites_VMs[0].uniteId;
      }
    )

  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger1.unsubscribe();
    this.dtTrigger2.unsubscribe();
  }
}
