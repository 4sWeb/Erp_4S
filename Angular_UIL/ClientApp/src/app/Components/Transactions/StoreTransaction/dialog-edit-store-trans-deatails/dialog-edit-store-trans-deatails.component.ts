import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { storeTransDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { DialogEditStoreTransDetails } from '../transaction-specific/transaction-specific.component';

@Component({
  selector: 'app-dialog-edit-store-trans-deatails',
  templateUrl: './dialog-edit-store-trans-deatails.component.html',
  styleUrls: ['./dialog-edit-store-trans-deatails.component.css']
})
export class DialogEditStoreTransDeatailsComponent implements OnInit {

  editStoreTransDetails: storeTransDetails_VM;
  qty: number;
  notes: string;
  unitPrice: number;
  totalo: number;

  constructor(private dialogRef: MatDialogRef<DialogEditStoreTransDeatailsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogEditStoreTransDetails) {
    dialogRef.disableClose = true;

    this.editStoreTransDetails = data.editStoreTransDetails;
    this.qty = this.editStoreTransDetails.qty;
    this.notes = this.editStoreTransDetails.notes;
    this.unitPrice = this.editStoreTransDetails.unitPrice;
    this.totalo = this.editStoreTransDetails.totalo;

    console.log("From Edit Dialog Component", this.editStoreTransDetails);
  }

  ngOnInit() {
    this.editStoreTransDetails.qty = this.qty;
    this.editStoreTransDetails.notes = this.notes;
    this.editStoreTransDetails.unitPrice = this.unitPrice;
    this.editStoreTransDetails.totalo = this.totalo;
  }

  updateStoreTransDetails() {
    this.totalo = this.qty * this.unitPrice;
    this.editStoreTransDetails.qty = this.qty;
    this.editStoreTransDetails.notes = this.notes;
    this.editStoreTransDetails.unitPrice = this.unitPrice;
    this.editStoreTransDetails.totalo = this.totalo;

  }
  onNoClick(): void {
    console.log(this.editStoreTransDetails);
    this.dialogRef.close();
  }
  onKeyQuantity(event: any) {
    this.qty = event.target.value;
    this.totalo = this.qty * this.unitPrice;
  }

  onKeyPrice(event: any) {
    this.unitPrice = event.target.value;
    this.totalo = this.qty * this.unitPrice;
  }

}
