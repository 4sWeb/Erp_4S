import { AfterViewInit, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { DataTableDirective } from 'angular-datatables';
import { Observable, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';
import { DialogContentDatatabelComponent } from '../dialog-content-datatabel/dialog-content-datatabel.component';
import { TransactionSpecific } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transaction-specific';
import { AllTransactions } from '../../../../models/Transactions/StoreTransaction/AllStoreTransacion/all-transactions';
import { TransactionsDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-details';
import { ToTypeDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/to-type-details';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { StoreTransMain } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-main';
import { StoreTransMaster } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-master';
import { StoreTransDep } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-dep';
import { StoreTransDepDetails } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-dep-details';
import { StoreTransDetails } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-details';
import { Result } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/Result';
import { FromType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/from-type';
import { FromTypeDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/from-type-details';
import { ToType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/to-type';

export interface DialogData {
  selectedTransaction?: number;
  checkedTransactionsIds?: number[];
  checkedTransactionsMain?: TransactionsDetails[];
}

@Component({
  selector: 'app-transaction-specific',
  templateUrl: './transaction-specific.component.html',
  styleUrls: ['./transaction-specific.component.css']
})
export class TransactionSpecificComponent implements OnInit,OnDestroy,AfterViewInit {

  constructor(public TransactionsService: TransactionsService, public ar: ActivatedRoute, public dialog: MatDialog) { }
   
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
  productdetails?: DependancyProduct[];

  Price: number;
  Quantity: number;

  //Save
  StoreTransMain?: StoreTransMain;
  storeTransMaster?: StoreTransMaster;
  StoreTransDep?: StoreTransDep;
  StoreTransDepDetails?: StoreTransDepDetails[];
  StoreTransDetails?: StoreTransDetails[];
  Branches: Result[];
  FromType: FromType[];
  FromTypeDetails: FromTypeDetails[];
  ToType: ToType[];
  ToTypeDetails: ToTypeDetails[];


  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;



 
  ngOnInit() {

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
        //Save
        this.StoreTransMain = response;
        this.StoreTransMain.stroreTransMaster = response.TransactionMasterSpec_VM;
        console.log("storeTransactionMain", this.StoreTransMain);
        
        this.FromType = response.TransactionMasterSpec_VM.From_Type;
        this.FromTypeDetails = response.TransactionMasterSpec_VM.FromTypeDetails;
        this.ToType = response.TransactionMasterSpec_VM.To_Type;
        this.ToTypeDetails = response.TransactionMasterSpec_VM.ToTypeDetails;
        console.log(this.Branches);
        console.log(this.FromType);
        console.log(this.FromTypeDetails);
        
        //this.storeTransMaster.TrnsNo = response.StoreTransMax;
        //this.storeTransMaster.Storedocnum = response.StoreTransMax;
        ////this.storeTransMaster.FromStoreAllcodesId=


        //view
        this.TransactionSpecific = response;
        console.log("this.TransactionSpecific", this.TransactionSpecific);
        this.AllTransactions = response.TransactionDepSpec.TrnsList;
        this.ToAllDetails = response.TransactionMasterSpec.ToTypeDetails;
        console.log("toAllType", this.ToAllDetails);
        
      },
      (error) => { console.log(error); })
  }



  ngAfterViewInit(): void {
   
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
        this.AllTransactions = response.TransactionDepSpec.TrnsList;
        console.log(this.selectedTransaction);
        this.dtTrigger1.next();
    });
  }



  //event handler for the select element's change event
  selectChangeHandler(event: any) {
    //update the ui
    $("#second-table").DataTable().clear().draw();
    
    this.selectedTransaction = event.target.value;

    console.log(this.selectedTransaction);
    this.TransactionsService.getTransactionsByDepID(this.selectedTransaction).subscribe(
      (response) => {
        console.log("selected id transaction", this.selectedTransaction);
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
      //this.productdetails = [];

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
    console.log("product", i)
    //to delete main product if all of child item is deleted
    let count = 0;
    for (let j = 0; j < this.productdetails.length; j++) {
      if (this.productdetails[j].Store_Trns_M_ID == id) {
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
    console.log("product after delete", this.productdetails)

  

  }

  deleteMainRecord(i, id: number) {
    console.log("mainRecordId", id);
    this.checkedTransactionsMain.splice(i, 1);
    console.log("this.checkedTransactionsMain", this.checkedTransactionsMain);

    ////to delete the id of this transaction from checkedTransaction id array
    //this.checkedTransactionsIds.forEach((element, index) => {
    //  if (element == id) this.checkedTransactionsIds.splice(index, 1);
    //});
    //console.log("this.checkedTransactionsIds", this.checkedTransactionsIds);

    //to delete productDetails related to mainTransaction
    for (let j = 0; j < this.productdetails.length; j++) {
      if (this.productdetails[j].Store_Trns_M_ID == id) {
        this.productdetails.splice(j, 1);


      }
    }
  }

  //calculate the value
  onKeyPrice(event: any) {
    this.Price = event.target.value;
    console.log("price", this.Price);
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


  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger1.unsubscribe();
    this.dtTrigger2.unsubscribe();
  }
}
