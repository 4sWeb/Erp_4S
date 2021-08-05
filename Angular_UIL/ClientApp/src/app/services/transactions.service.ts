import { HttpClient,HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, catchError } from 'rxjs/operators'

import { Observable} from 'rxjs';
import { Transactions } from '../models/transactions';
import { AllTransactions } from '../models/all-transactions';
import { environment } from '../../environments/environment.prod';
import { TransactionSpecific } from '../models/transaction-specific';
import { TransactionsDetails } from '../models/transactions-details';




//const API_Transaction = 'http://10.8.2.153:9064/transaction';

@Injectable({
  providedIn: 'root'
})
export class TransactionsService {

  constructor(private http: HttpClient) {
  console.log("from services");}

  
//get list of transaction
  getAllTransactions(UserID: number, AppID: number, periodID: number): Observable<Transactions[]> {
    console.log(UserID, AppID);
    return this.http.get<Transactions[]>(`${environment.Api_Url}?UserID=${UserID}&AppID=${AppID}&PeriodID=${periodID}`)
  }



//display all transactions related to one transaction
  displayAllTransactions(id: number, PeriodID: number): Observable<AllTransactions[]> {
    console.log(id);
    console.log(PeriodID);
    return this.http.get<AllTransactions[]>(`${environment.Api_Url}/DisplayAllTransaction?id=${id}&PeriodID=${PeriodID}`)
  }


  //get all feildes neaded to create specific transaction
  displayAllFieldesSpecificTransaction(id: number, userId: number): Observable<TransactionSpecific> {
    console.log(id);
    return this.http.get<TransactionSpecific>(`${environment.Api_Url}/TransactionSpec?id=${id}&userId=${userId}`);
  }

  //get all feildes neaded to create specific transaction
  getTransactionsByDepID(id: number): Observable<TransactionsDetails[]> {
    console.log(id);
    return this.http.get<TransactionsDetails[]>(`${environment.Api_Url}/GetTransactionsByDepID?DepTransID=${id}`)
  }





  //getAllTransactions(UserID: number, AppID: number, periodID: number): Observable<any> {
  //  return this.http.get<Transactions[]>(`${API_Transaction} /UserID=${UserID}&AppID=${AppID}&${periodID}`, { observe: 'response' })
  //    .pipe(
  //      map((res) => {
  //        if (res) {
  //          if (res.status === 200) {
  //            console.log(res.body);
  //            return res.body;

  //          }
  //          return res.status;
  //        }
  //      }),
  //      catchError((error: any) => {
  //        if (error.status > 400 || error.status === 500) {
  //          return [{ status: error.status }];
  //        }
  //        return error.status;
  //      })
  //    );
  //}
}

function AppID<T>(API_Transaction: string, arg1: any, AppID: any, periodID: any, arg4: { observe: string; }) {
    throw new Error('Function not implemented.');
}
