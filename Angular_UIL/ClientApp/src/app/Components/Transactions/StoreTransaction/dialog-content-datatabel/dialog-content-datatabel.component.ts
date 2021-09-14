import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Subject } from 'rxjs';
import { storeTransDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { TransactionsDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-details';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';
import { DialogData } from '../transaction-specific/transaction-specific.component';

@Component({
  selector: 'app-dialog-content-datatabel',
  templateUrl: './dialog-content-datatabel.component.html',
  styleUrls: ['./dialog-content-datatabel.component.css']
})
export class DialogContentDatatabelComponent implements OnInit, OnDestroy {


  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject<any>();
  selectedTransaction: number;
  TransactionsDetails?: TransactionsDetails[];

  checkedTransactionsMain?: TransactionsDetails[];

  checkedTransactions?: number[];
  checkedTransactionsIds?: number[];
  DependancyProduct?: storeTransDetails_VM[];

  constructor(public TransactionsService: TransactionsService,
    private dialogRef: MatDialogRef<DialogContentDatatabelComponent>,
    @Inject(MAT_DIALOG_DATA)public data:DialogData) {

    dialogRef.disableClose = true;
    this.selectedTransaction = data.selectedTransaction;
    this.checkedTransactionsIds = data.checkedTransactionsIds;
    this.checkedTransactionsMain = data.checkedTransactionsMain;
    console.log("from Dialoogggg component", this.selectedTransaction);
    console.log("from Dialoogggg component2", this.checkedTransactionsIds);
    console.log("from Dialoogggg component2", this.checkedTransactionsMain);
  }



  ngOnInit() {

    this.checkedTransactions = new Array<number>();
    this.checkedTransactionsIds = new Array<number>();
    this.checkedTransactionsMain = new Array<TransactionsDetails>();

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5
    };

    this.TransactionsService.getTransactionsByDepID(this.selectedTransaction).subscribe(
      (response) => {
        console.log("selected id transaction", this.selectedTransaction);
        this.TransactionsDetails = response;
        console.log("selected id transaction", response)
        this.dtTrigger.next();
      });
    this.dtTrigger.next();
  }

  getAllCheckedTransId(e: any, id: number) {
    if (e.target.checked) {
      console.log(id + "checked");
      //var listofrows = $('#tabel1').DataTable().rows({ selected: true }).data().toArray();
      this.checkedTransactions.push(id);
    } else {
      console.log(id + "unchecked");
      this.checkedTransactions = this.checkedTransactions.filter(m => m != id);
    }
    
    //console.log("listOfRows", listofrows)
    console.log("checkedTransactions",this.checkedTransactions);
  }

  ShowProduct() {
    this.TransactionsService.getAllProductDetails(this.checkedTransactions).subscribe(
      (response) => {
       
        this.DependancyProduct = response;
        console.log("DependancyProduct", this.DependancyProduct);
        
      });
  
  }

  getAllCheckedTransaction(e: any, trns: TransactionsDetails,id:number) {
    if (e.target.checked) {
      console.log(trns + "checked");
      console.log(this.checkedTransactionsMain.push(trns));
      this.checkedTransactionsIds.push(id);

    } else {
      console.log(trns + "unchecked");
      this.checkedTransactionsMain = this.checkedTransactionsMain.filter(m => m != trns);
      this.checkedTransactionsIds = this.checkedTransactionsIds.filter(m => m != id);
      

    }

    console.log("checkedTransactionsItem", this.checkedTransactionsMain);
  
    console.log("checkedTransactionsIds", this.checkedTransactionsIds);
  }

  onNoClick(): void {
    this.dialogRef.close();
    //console.log("checkedTransactions", this.checkedTransactions);
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

}
