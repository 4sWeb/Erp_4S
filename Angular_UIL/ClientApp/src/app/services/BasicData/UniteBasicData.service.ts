import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators'
import { environment } from '../../../environments/environment';
import { UnitesBasic_VM } from '../../models/BasicData/UnitesBasic_VM';

@Injectable({
  providedIn: 'root'
})
export class UniteBasicDataService {

  constructor(private http: HttpClient) { }

  //Get list of Unites
  GetAllUnites(): Observable<any>
  {
    return this.http.get<UnitesBasic_VM[]>(`${environment.Api_Url}/BasicData/DisplayAllUnites`, { observe: 'response' })
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

  //Create UnitesBasic
  CreateUnitesBasic(uniteBasic: UnitesBasic_VM): Observable<any> {
    return this.http.post<UnitesBasic_VM>(`${environment.Api_Url}/BasicData/CreateUnite`, uniteBasic);
  };

  //Delete UnitesBasic
  DeleteUnitesBasic(UnitesBasicId: number): Observable<any>
  {
    console.log("services", UnitesBasicId);
    return this.http.get(`${environment.Api_Url}/BasicData/deleteUnite?uniteId=${UnitesBasicId}`, { observe: 'response' })
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

    //Update UnitesBasic
    UpdateUnitesBasic(uniteBasic: UnitesBasic_VM): Observable<any> {
    return this.http.put<UnitesBasic_VM>(`${environment.Api_Url}/BasicData/EditUnite`, uniteBasic);
  };

}
