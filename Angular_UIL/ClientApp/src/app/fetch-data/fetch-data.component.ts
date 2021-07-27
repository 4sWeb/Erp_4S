import { AfterViewInit, Component, Inject, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TransactionsService } from '../services/transactions.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit,AfterViewInit {

  
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
  
  ngAfterViewInit(): void {
      throw new Error('Method not implemented.');
    }
  ngOnInit(): void {
  
        throw new Error('Method not implemented.');
    }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
