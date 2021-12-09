import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Response_VM } from '../../models/Shared/ReSponse_VM';
import { UserCredential_VM } from '../../models/Users/UserCredential_VM';
import { Users_VM } from '../../models/Users/Users_VM';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { }


  //CheckUserCredential
  CheckUserCredential(UserCredential: UserCredential_VM): Observable<Response_VM> {
     console.log("UserCredential", UserCredential);
     return this.http.post<Response_VM>(`${environment.Api_Url}/User/Login`, UserCredential);
  }

  //Retrive all Modules
  GetAllModule(): Observable<Response_VM> {
    
    return this.http.get<Response_VM>(`${environment.Api_Url}/User/DisplayAllModules`);

  }
}
