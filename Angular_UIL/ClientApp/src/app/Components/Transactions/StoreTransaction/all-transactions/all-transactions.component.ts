import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { AllTransactions } from '../../../../models/Transactions/StoreTransaction/AllStoreTransacion/all-transactions';
import { SharingDataService } from '../../../../services/SharingData/sharing-data.service';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';

@Component({
  selector: 'app-all-transactions',
  templateUrl: './all-transactions.component.html'
})
export class AllTransactionsComponent implements  OnDestroy, OnInit {

  dtOptions: DataTables.Settings = {};

  alltransactions: AllTransactions[];

  dtTrigger: Subject<any> = new Subject<any>();

  operationType: any;
  StoreTransMId: number;
  TransCode: number;

  constructor(private TransactionsService: TransactionsService, private SharingDataService: SharingDataService, public ar: ActivatedRoute) {
    this.TransCode = this.SharingDataService.getTransCode();
    console.log("this.TransCode", this.TransCode);
  }

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


  //SetType of operation=add
  setAddOperation() {
    this.operationType = "Add";
    this.SharingDataService.setOperationType(this.operationType);
    console.log("helloAdd", this.operationType);
  }

  //SetType of operation=View
  setViewOperation(StoreTransMId) {
    this.StoreTransMId = StoreTransMId;
    console.log("StoreTransMId",StoreTransMId);
    this.operationType = "View";
    this.SharingDataService.setOperationType(this.operationType);
    this.SharingDataService.setStoreTransMId(this.StoreTransMId);
    console.log("helloView", this.operationType);
    console.log("StoreTransMId", this.StoreTransMId);
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

}
