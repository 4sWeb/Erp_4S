import { AfterViewInit, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { DataTableDirective } from 'angular-datatables';
import { Observable, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { AllTransactions } from '../models/all-transactions';
import { TransactionSpecific } from '../models/transaction-specific';
import { TransactionsDetails } from '../models/transactions-details';
import { TransactionsService } from '../services/transactions.service';

@Component({
  selector: 'app-transaction-specific',
  templateUrl: './transaction-specific.component.html',
  styleUrls: ['./transaction-specific.component.css']
})
export class TransactionSpecificComponent implements OnInit,OnDestroy,AfterViewInit {

  constructor(public TransactionsService: TransactionsService, public ar: ActivatedRoute) { }
   
  TransactionSpecific: TransactionSpecific;
  AllTransactions?: AllTransactions[];
  TransactionsDetails?: TransactionsDetails[];
  dtOptions: DataTables.Settings[] = [];
  dtTrigger1: Subject<any> = new Subject();
  dtTrigger2: Subject<any> = new Subject();
  selectedTransaction: number;

  @ViewChild(DataTableDirective, { static: false })
  dtElement: DataTableDirective;



 
  ngOnInit() {

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
    this.ar.params.subscribe(
      a => {
        id = a['id'];
      }
    )


    this.TransactionsService.displayAllFieldesSpecificTransaction(id).subscribe(
      (response) => {
        console.log(id);
        console.log("response", response);
        this.TransactionSpecific = response;
        this.AllTransactions = response.TrnsList;
        
      },
      (error) => { console.log(error); })
  }



  ngAfterViewInit(): void {

    let id = 0;
    this.ar.params.subscribe(
      a => {
        id = a['id'];
      }
    )
    this.TransactionsService.displayAllFieldesSpecificTransaction(id).subscribe(
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

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger1.unsubscribe();
    this.dtTrigger2.unsubscribe();
  }
}
