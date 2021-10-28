import { HttpClient,HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, catchError } from 'rxjs/operators'

import { Observable, pipe} from 'rxjs';
import { Transactions } from '../../models/Transactions/transactions';
import { AllTransactions } from '../../models/Transactions/StoreTransaction/AllStoreTransacion/all-transactions';
import { environment } from '../../../environments/environment';
import { TransactionSpecific } from '../../models/Transactions/StoreTransaction/TransactionSpecification/transaction-specific';
import { TransactionsDetails } from '../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-details';
import { DependancyProduct } from '../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { StoreTransMain } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/store-trans-main';
import { GroupF_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupF_VM';
import { ItemDetails_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemDetails_VM';
import { Unites_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Unites_VM';
import { storeTransDetails_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { GroupItemsUnits_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupItemsUnits_VM';
import { ItemsWithBalance_VM } from '../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemsWithBalance_VM';
import { StoreDepSpecDetails_VM } from '../../models/Transactions/StoreTransaction/TransactionDepSpecification/StoreDepSpecDetails_VM';




//const API_Transaction = 'http://10.8.2.153:9064/transaction';

@Injectable({
  providedIn: 'root'
})
export class TransactionsService {

  constructor(private http: HttpClient) {
    console.log("**********from services*************");
    this.GetAllGroupsWithItemsDetails(1).subscribe(
      res => {
        console.log("*************GetAllGroupsWithItemsDetails From SHaring service Constructor*******", res);
        this.ShraingListOfGroupsandItems = res;
        this.ListOfGroupsandItemsReady = true;
        
      }
    );

  }

  ShraingListOfGroupsandItems: GroupItemsUnits_VM[];
  ListOfGroupsandItemsReady: boolean= false;


  
//get list of transaction
  getAllTransactions(UserID: number, AppID: number, periodID: number): Observable<any> {
    console.log(UserID, AppID);
    return this.http.get<Transactions[]>(`${environment.Api_Url}?UserID=${UserID}&AppID=${AppID}&PeriodID=${periodID}`, { observe: 'response' })
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



//display all transactions related to one transaction
  displayAllTransactions(id: number, PeriodID: number): Observable<AllTransactions[]> {
    console.log(id);
    console.log(PeriodID);
    return this.http.get<AllTransactions[]>(`${environment.Api_Url}/DisplayAllTransaction?id=${id}&PeriodID=${PeriodID}`)
  }


  //get all feildes neaded to create specific transaction
  displayAllFieldesSpecificTransaction(id: number, userId: number): Observable<TransactionSpecific|any> {
    console.log(id);
    return this.http.get<TransactionSpecific | any>(`${environment.Api_Url}/TransactionSpec?transCode=${id}&userId=${userId}`);
  }

  //get all feildes neaded to create specific transaction
  getTransactionsByDepID(id: number): Observable<TransactionsDetails[]> {
    console.log(id);
    return this.http.get<TransactionsDetails[]>(`${environment.Api_Url}/GetTransactionsByDepID?DepTransID=${id}`)
  }

  //get all product dependancies
  getAllProductDetails(ids: number[], GetItem: number): Observable<storeTransDetails_VM[]> {
    console.log("idsFrom Services", ids);
    return this.http.post<storeTransDetails_VM[]>(`${environment.Api_Url}/DisplayItems?GetItems=${GetItem}`,ids);
  }

  //Retrive all details about StoreTransaction by storeTransMId
  getTransactionByStoreTrnsMId(storeTrnsMId: number): Observable<StoreTransMain> {
    console.log("storetrnsMId From services",storeTrnsMId);
    return this.http.get<StoreTransMain>(`${environment.Api_Url}/Retrieve?storeTransMId=${storeTrnsMId}`);

  }
  /////////////////////*********************Services Details************************//////////////////

  //Retrieve all Groups of Details
  getAllGroups(): Observable<GroupF_VM[]> {
    return this.http.get<GroupF_VM[]>(`${environment.Api_Url}/GetGroupFDetails`);
  }

  //Get Items and unite and price when group dropdown changed
  getItemsDetails(groupFId: number): Observable<ItemDetails_VM> {
    return this.http.get<ItemDetails_VM>(`${environment.Api_Url}/GetItemsDetails?GroupF_Id=${groupFId}`);
  }

  //Get Unites when Item dropdown changed
  getUnitesDetails(itemId: number): Observable<Unites_VM[]> {
    return this.http.get<Unites_VM[]>(`${environment.Api_Url}/GetUnitesDetails?storeItemId=${itemId}`);
  }

  GetAllGroupsWithItemsDetails(PeriodId: number): Observable<GroupItemsUnits_VM[]> {
    console.log("hiii servexies");
    return this.http.get<GroupItemsUnits_VM[]>(`${environment.Api_Url}/GetAllGroupsWithItemsDetails?PeriodId=${PeriodId}`)
  };

  //Get All Items With Balance
  GetAllItemsBalance(): Observable<ItemsWithBalance_VM[]> {
    console.log("hiii servexies Get All Items With Balance");
    return this.http.get<ItemsWithBalance_VM[]>(`${environment.Api_Url}/GetItemsWithAndBalance`)
  };

  //Create Transaction
  CreateTransaction(stroreTransMain: StoreTransMain): Observable<any>{
    return this.http.post<StoreTransMain>(`${environment.Api_Url}/SaveOrder`, stroreTransMain);
  };


  //Delete Transaction
  DeleteTransaction(storeTransMId: number): Observable<any> {
    console.log("services", storeTransMId);
    return this.http.get(`${environment.Api_Url}/deleteOrder?trnsID=${storeTransMId}`, { observe: 'response' })
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

  //Get Specification For StoreTransDependancy
  //StoreDepSpecDetails_VM
  GetSpecificationForDependancy(DepTransID: number): Observable<StoreDepSpecDetails_VM> {
    return this.http.get<StoreDepSpecDetails_VM>(`${environment.Api_Url}/TransactionDepSpec?StoreDepSpecID=${DepTransID}`);
  }
  }



