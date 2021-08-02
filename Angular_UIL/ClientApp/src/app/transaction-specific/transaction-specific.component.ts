import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Observable, Subject } from 'rxjs';
import { map } from 'rxjs/operators';
import { AllTransactions } from '../models/all-transactions';
import { TransactionSpecific } from '../models/transaction-specific';
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
  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject<any>();
 
  ngOnInit() {

      this.dtOptions = {
        pagingType: 'full_numbers',
        pageLength: 5
      };

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
        this.dtTrigger.next();
    });
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }
}
