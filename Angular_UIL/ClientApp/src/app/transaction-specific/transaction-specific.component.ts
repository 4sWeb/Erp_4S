import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { TransactionSpecific } from '../models/transaction-specific';
import { TransactionsService } from '../services/transactions.service';

@Component({
  selector: 'app-transaction-specific',
  templateUrl: './transaction-specific.component.html',
  styleUrls: ['./transaction-specific.component.css']
})
export class TransactionSpecificComponent implements OnInit {

  constructor(public TransactionsService: TransactionsService, public ar: ActivatedRoute) { }
  TransactionSpecific: TransactionSpecific;
 
  ngOnInit() {

    

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
      },
      (error) => { console.log(error); })
  }





}
