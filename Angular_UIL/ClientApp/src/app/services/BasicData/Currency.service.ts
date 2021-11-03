import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from '../../../environments/environment';
import { CurrencyMain_VM } from '../../models/BasicData/CurrencyMain_VM';

@Injectable({
  providedIn: 'root'
})
export class CurrencyService {

  constructor(private http: HttpClient) { }

  //Get list of Currency
  GetAllCurrency(): Observable<any> {
    return this.http.get<CurrencyMain_VM[]>(`${environment.Api_Url}/BasicData/DisplayAllCurrency`, { observe: 'response' })
      .pipe(
        map((res) => {
          if (res) {
            if (res.status === 200) {
              console.log(res.body);
              return res.body;

            }
            return res.status;
          }
        }),
        catchError((error: any) => {
          if (error.status > 400 || error.status === 500) {
            return [{ status: error.status }];
          }
          return error.status;
        })
      );
  }

  //Create Currency
  CreateCurrency(currencyMain: CurrencyMain_VM): Observable<any> {
    return this.http.post<CurrencyMain_VM>(`${environment.Api_Url}/BasicData/CreateCurrency`, currencyMain);
  };

  //Delete Currency
  DeleteCurrency(currencyId: number): Observable<any> {
    console.log("services", currencyId);
    return this.http.get(`${environment.Api_Url}/BasicData/DeleteCurrency?currencyId=${currencyId}`, { observe: 'response' })
      .pipe(
        map((res) => {
          if (res) {
            if (res.status === 200) {
              console.log(res.body);
              return res.body;

            }
            return res.status;
          }
        }),
        catchError((error: any) => {
          if (error.status > 400 || error.status === 500) {
            return [{ status: error.status }];
          }
          return error.status;
        })
      );
  }

  //Update Currency
  UpdateCurrency(currencyMain: CurrencyMain_VM): Observable<any> {
    return this.http.put<CurrencyMain_VM>(`${environment.Api_Url}/BasicData/EditCurrency`, currencyMain);
  };
}
