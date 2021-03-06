import { error } from '@angular/compiler/src/util';
import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { inputs } from '@syncfusion/ej2-angular-calendars/src/datetimepicker/datetimepicker.component';
import { Subject } from 'rxjs';
import { Transactions } from '../../../models/Transactions/transactions';
import { SharingDataService } from '../../../services/SharingData/sharing-data.service';
import { TransactionsService } from '../../../services/StoreTransaction/transactions.service';

@Component({
  selector: 'app-transactions-list',
  templateUrl: './transactions-list.component.html',
  styleUrls: ['./transactions-list.component.css']
})
export class TransactionsListComponent implements OnDestroy,OnInit {
  dtOptions: DataTables.Settings = {};

  alltransactions: Transactions[];
  TransCode: number;
  UserId: number;
  AppId: number;
  dtTrigger: Subject<any> = new Subject<any>();

  constructor(private TransactionsService: TransactionsService, private SharingDataService: SharingDataService) {
    console.log("running");
  }

  ngOnInit() {
    $("#states").width;
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 10
    };
    console.log("on int");
    this.UserId = parseInt(localStorage.getItem('UserId'));
    this.AppId = parseInt(localStorage.getItem('AppId'));
    this.TransactionsService.getAllTransactions(this.UserId, this.AppId, 2).subscribe(
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
