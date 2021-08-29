import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Subject } from 'rxjs';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { DialogEdit } from '../transaction-specific/transaction-specific.component';

@Component({
  selector: 'app-dialog-edit-product',
  templateUrl: './dialog-edit-product.component.html',
  styleUrls: ['./dialog-edit-product.component.css']
})
export class DialogEditProductComponent implements OnInit {

  editProduct: DependancyProduct;
  Quantity: number;
  Note: string;

  constructor(private dialogRef: MatDialogRef<DialogEditProductComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogEdit) {
    dialogRef.disableClose = true;

    this.editProduct = data.editProduct;
    this.editProduct.Quantity = this.Quantity;
    this.editProduct.Note = this.Note;
    console.log("From Edit Dialog Component", this.editProduct);
  }

  ngOnInit() {
    console.log("onInt");
    this.editProduct.Quantity = this.Quantity;
    this.editProduct.Note = this.Note;
    console.log("From Edit Dialog Component", this.editProduct);
 
  }

  onNoClick(): void {
    console.log(this.editProduct);
    this.dialogRef.close();
  }

}
