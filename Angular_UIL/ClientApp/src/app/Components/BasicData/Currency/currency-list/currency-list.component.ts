import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { CurrencyMain_VM } from '../../../../models/BasicData/CurrencyMain_VM';
import { CurrencyMaster_VM } from '../../../../models/BasicData/CurrencyMaster_VM';
import { CurrencyRates_VM } from '../../../../models/BasicData/CurrencyRates_VM';
import { CurrencyService } from '../../../../services/BasicData/Currency.service';

@Component({
  selector: 'app-currency-list',
  templateUrl: './currency-list.component.html',
  styleUrls: ['./currency-list.component.css']
})
export class CurrencyListComponent implements OnInit,OnDestroy {

  dtOptions: DataTables.Settings = {};

  CurrencyMain: CurrencyMain_VM[] = [];
  CurrencyMaster: CurrencyMaster_VM[] = [];
  CurrencyRates: CurrencyRates_VM[] = [];

  editCurrencyMaster: CurrencyMaster_VM;
  editCurrencyMain: CurrencyMain_VM;

  editCurrencyRate: CurrencyRates_VM ;

  dtTrigger: Subject<any> = new Subject<any>();

  //ForEditMode
  EditeMood: boolean = false;

  //For Date Picker
  public Datevalue: Date = new Date();
  public maxDate: Date = new Date();

  //For Binding


  constructor(public ar: ActivatedRoute, public currencyService: CurrencyService)
  {

    this.currencyService.GetAllCurrency().subscribe
      (
        (response) => {
          this.CurrencyMain = response;
          console.log("response", response);
          console.log("CurrencyMain", this.CurrencyMain);
          for (var i = 0; i < this.CurrencyMain.length; i++)
          {

            this.CurrencyMaster.push(this.CurrencyMain[i].CurrencyMaster_VM);
          };

          console.log("CurrencyMaster", this.CurrencyMaster);
          for (var i = 0; i < this.CurrencyMain.length; i++)
          {
            for (var J = 0; J < this.CurrencyMain[i].CurrencyRates_VM.length; J++)
            {
              this.CurrencyRates.push(this.CurrencyMain[i].CurrencyRates_VM[J]);
            }
          };
          console.log("CurrencyRates", this.CurrencyRates);
          this.dtTrigger.next();

        },
    )

  };
 

  ngOnInit()
  {
    this.dtOptions =
    {
      pagingType: 'full_numbers',
      pageLength: 3
    };
  };

  EditCurrencyMaster(i: number)
  {
    this.editCurrencyMain = this.CurrencyMain[i];
    this.editCurrencyMain.CurrencyRates_VM=null;
    this.editCurrencyMaster = this.CurrencyMain[i].CurrencyMaster_VM;
    console.log("this.editCurrencyMaster", this.editCurrencyMaster);
    console.log("this.editCurrencyMain", this.editCurrencyMain);
    this.currencyService.UpdateCurrency(this.editCurrencyMain).subscribe
      (
        (res) => {
          console.log("res", res);
        }
      )
  };

  //ViewCurrency(i: number) {
  //  this.AcurrUnit1 = this.CurrencyMain[i].CurrencyMaster_VM.AcurrUnit1;
  //  this.AcurrUnit2 = this.CurrencyMain[i].CurrencyMaster_VM.AcurrUnit2;
  //  this.AcurrUnit3 = this.CurrencyMain[i].CurrencyMaster_VM.AcurrUnit3;
  //  this.AcurrUnit4 = this.CurrencyMain[i].CurrencyMaster_VM.AcurrUnit4;
  //  this.EcurrUnit1 = this.CurrencyMain[i].CurrencyMaster_VM.EcurrUnit1;
  //  this.EcurrUnit2 = this.CurrencyMain[i].CurrencyMaster_VM.EcurrUnit2;
  //  this.EcurrUnit3 = this.CurrencyMain[i].CurrencyMaster_VM.EcurrUnit3;
  //  this.EcurrUnit4 = this.CurrencyMain[i].CurrencyMaster_VM.EcurrUnit4;
  //  this.AfracUnit1 = this.CurrencyMain[i].CurrencyMaster_VM.AfracUnit1;
  //  this.AfracUnit2 = this.CurrencyMain[i].CurrencyMaster_VM.AfracUnit2;
  //  this.AfracUnit3 = this.CurrencyMain[i].CurrencyMaster_VM.AfracUnit3;
  //  this.AfracUnit4 = this.CurrencyMain[i].CurrencyMaster_VM.AfracUnit4;
  //  this.EfracUnit1 = this.CurrencyMain[i].CurrencyMaster_VM.EfracUnit1;
  //  this.EfracUnit2 = this.CurrencyMain[i].CurrencyMaster_VM.EfracUnit2;
  //  this.EfracUnit3 = this.CurrencyMain[i].CurrencyMaster_VM.EfracUnit3;
  //  this.EfracUnit4 = this.CurrencyMain[i].CurrencyMaster_VM.EfracUnit4;
  //};

  EditCurrencuRate(i: number, j: number)
  {
    console.log(i, j);
    this.EditeMood = true;

  }

  SaveEditCurrncRate(i: number, j: number)
  {
    this.editCurrencyMain = this.CurrencyMain[i];
    this.editCurrencyMain.CurrencyRates_VM[0] = this.CurrencyMain[i].CurrencyRates_VM[j];
    console.log("this.editCurrencyMain", this.editCurrencyMain);
    this.currencyService.UpdateCurrency(this.editCurrencyMain).subscribe
      (
        (res) =>
        {
          console.log("res", res);
        }
      )
  }

  ngOnDestroy()
  {
    this.dtTrigger.unsubscribe();
  };

}
