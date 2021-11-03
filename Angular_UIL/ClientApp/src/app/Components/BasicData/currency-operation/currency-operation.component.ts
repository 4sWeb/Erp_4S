import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CurrencyMain_VM } from '../../../models/BasicData/CurrencyMain_VM';
import { CurrencyMaster_VM } from '../../../models/BasicData/CurrencyMaster_VM';
import { CurrencyRates_VM } from '../../../models/BasicData/CurrencyRates_VM';
import { CurrencyService } from '../../../services/BasicData/Currency.service';

@Component({
  selector: 'app-currency-operation',
  templateUrl: './currency-operation.component.html',
  styleUrls: ['./currency-operation.component.css']
})
export class CurrencyOperationComponent implements OnInit {

  constructor(public ar: ActivatedRoute, public currencyService: CurrencyService)
  {
    this.currencyService.GetAllCurrency().subscribe
      (
        (response) =>
        {
          this.CurrencyMain = response;
          console.log("response", response);
          console.log("CurrencyMain", this.CurrencyMain);
          for (var i = 0; i < this.CurrencyMain.length; i++)
          {
            this.CurrencyMaster.push(this.CurrencyMain[i].CurrencyMaster_VM );
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
        }

      )
  }

  CurrencyMain: CurrencyMain_VM[]=[];
  CurrencyMaster: CurrencyMaster_VM[]=[];
  CurrencyRates: CurrencyRates_VM[]=[];

  ngOnInit()
  {
  }

}
