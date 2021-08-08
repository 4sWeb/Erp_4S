import { AfterViewInit, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { DataTableDirective } from 'angular-datatables';
import { Observable, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { AllTransactions } from '../models/all-transactions';
import { TransactionSpecific } from '../models/transaction-specific';
import { TransactionsDetails } from '../models/transactions-details';
import { TransactionsService } from '../services/transactions.service';
import { DialogContentDatatabelComponent } from '../dialog-content-datatabel/dialog-content-datatabel.component';
import { ToTypeDetails } from '../models/to-type-details';

export interface DialogData {
  selectedTransaction?: number;
  checkedTransactions?: number[];
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

  checkedTransactions?: number[];


  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;



 
  ngOnInit() {

    this.checkedTransactions = new Array<number>();

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
        this.AllTransactions = response.TrnsList;
        this.ToAllDetails = response.ToTypeDetails;
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
        this.AllTransactions = response.TrnsList;
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
      data: { selectedTransaction: this.selectedTransaction, checkedTransactions: this.checkedTransactions }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed', result);
      this.checkedTransactions = result;
      console.log("From main component checkedTransactions", this.checkedTransactions)
    });
    return dialogRef.afterClosed();
  }


  getAllCheckedTransId(e: any,id: number) {
    if (e.target.checked) {
      console.log(id + "checked");
      this.checkedTransactions.push(id);
    } else {
      console.log(id + "unchecked");
      this.checkedTransactions = this.checkedTransactions.filter(m => m != id);
    }
    console.log(this.checkedTransactions);
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger1.unsubscribe();
    this.dtTrigger2.unsubscribe();
  }
}
