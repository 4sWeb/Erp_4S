import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Subject } from 'rxjs';
import { DependancyProduct } from '../models/dependancy-product';
import { TransactionsDetails } from '../models/transactions-details';
import { TransactionsService } from '../services/transactions.service';
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

  checkedTransactions?: number[];
  DependancyProduct?: DependancyProduct[];

  constructor(public TransactionsService: TransactionsService,
    private dialogRef: MatDialogRef<DialogContentDatatabelComponent>,
    @Inject(MAT_DIALOG_DATA)public data:DialogData) {

    this.selectedTransaction = data.selectedTransaction;
    this.checkedTransactions = data.checkedTransactions;
    console.log("from Dialoogggg component", this.selectedTransaction);
    console.log("from Dialoogggg component2", this.checkedTransactions);
  }



  ngOnInit() {

    this.checkedTransactions = new Array<number>();

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
      this.checkedTransactions.push(id);
    } else {
      console.log(id + "unchecked");
      this.checkedTransactions = this.checkedTransactions.filter(m => m != id);
    }
    console.log("checkedTransactions",this.checkedTransactions);
  }

  ShowProduct() {
    this.TransactionsService.getAllProductDetails(this.checkedTransactions).subscribe(
      (response) => {
       
        this.DependancyProduct = response;
        console.log("DependancyProduct", this.DependancyProduct);
        
      });
  
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
