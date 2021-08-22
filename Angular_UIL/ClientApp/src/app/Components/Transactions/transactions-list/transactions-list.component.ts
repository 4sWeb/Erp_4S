import { error } from '@angular/compiler/src/util';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { Transactions } from '../../../models/Transactions/transactions';
import { TransactionsService } from '../../../services/StoreTransaction/transactions.service';

@Component({
  selector: 'app-transactions-list',
  templateUrl: './transactions-list.component.html',
  styleUrls: ['./transactions-list.component.css']
})
export class TransactionsListComponent implements OnDestroy,OnInit {
  dtOptions: DataTables.Settings = {};

  alltransactions: Transactions[];

  dtTrigger: Subject<any> = new Subject<any>();

  constructor(private TransactionsService: TransactionsService) {
    console.log("running");
  }

  ngOnInit() {

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 10
    };
    console.log("on int");

    this.TransactionsService.getAllTransactions(1, 2, 2).subscribe(
      (Response) => {
        console.log(Response);
        this.alltransactions = Response;
        this.dtTrigger.next();
      },
      (error) => { console.log(error); })
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

  //getAllTransaction(): void {
  //  this.alltransactions = this.TransactionsService.getAllTransactions(1, 2, 2).subscribe(
  //    (Response) => {
  //      this.alltransactions = Response;
  //      console.log(Response);
  //    },
  //    (error) => { console.log("errrrrrrrrrrrrrrror"+error) });
  //}
}
