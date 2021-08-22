import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { AllTransactions } from '../../../../models/Transactions/StoreTransaction/AllStoreTransacion/all-transactions';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';

@Component({
  selector: 'app-all-transactions',
  templateUrl: './all-transactions.component.html'
})
export class AllTransactionsComponent implements  OnDestroy, OnInit {

  dtOptions: DataTables.Settings = {};

  alltransactions: AllTransactions[];

  dtTrigger: Subject<any> = new Subject<any>();
  constructor(private TransactionsService: TransactionsService, public ar: ActivatedRoute) { }

  ngOnInit() {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 10
    };


    let id = 0;
    this.ar.params.subscribe(
      a => {
        id = a['id'];
      }
    )

    this.TransactionsService.displayAllTransactions(id, 2).subscribe(
      (response) => {
        console.log(id);
        console.log("response",response);
        this.alltransactions = response;
        this.dtTrigger.next();
      },
      (error) => { console.log(error); })
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

}
