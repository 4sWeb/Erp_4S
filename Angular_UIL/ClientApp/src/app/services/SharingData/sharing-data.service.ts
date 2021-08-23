import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SharingDataService {

  constructor() { }
  private operationType: any = undefined;

  setOperationType(data: any) {
    this.operationType = data;
  }

  getOperationType(): any {
    return this.operationType;
  }
}
