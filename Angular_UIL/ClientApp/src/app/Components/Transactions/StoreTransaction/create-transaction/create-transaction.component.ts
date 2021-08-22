import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-create-transaction',
  templateUrl: './create-transaction.component.html',
  styleUrls: ['./create-transaction.component.css']
})
export class CreateTransactionComponent implements OnInit {

  public minDate: Date = new Date("05/07/1000 2:00 AM");

  public maxDate: Date = new Date("05/27/3000 11:00 AM");

  public dateValue: Date = new Date();
  

  constructor(public ar: ActivatedRoute) { }
/*  filter$: Observable<string>;*/

  ngOnInit() {
    //this.filter$ = this.ar.queryParamMap.pipe(
    //  map((params: ParamMap) => params.get('filter')));
  }

}
