import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-transaction',
  templateUrl: './create-transaction.component.html',
  styleUrls: ['./create-transaction.component.css']
})
export class CreateTransactionComponent implements OnInit {

  public minDate: Date = new Date("05/07/1000 2:00 AM");

  public maxDate: Date = new Date("05/27/3000 11:00 AM");

  public dateValue: Date = new Date();
  

  constructor() { }

  ngOnInit() {
  }

}
