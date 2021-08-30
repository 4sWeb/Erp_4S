import { AfterViewInit, Component, Inject, OnInit } from '@angular/core';
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
  Value: number;
  Price: number;

  constructor(private dialogRef: MatDialogRef<DialogEditProductComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogEdit) {
    dialogRef.disableClose = true;

    this.editProduct = data.editProduct;
    this.Quantity = this.editProduct.Quantity;
    this.Note = this.editProduct.Note;
    this.Value = this.editProduct.Value;
    this.Price = this.editProduct.Price;
    console.log("From Edit Dialog Component", this.Quantity);
  }

  ngOnInit() {
    console.log("onInt");
    this.Quantity = this.editProduct.Quantity;
    this.Note = this.editProduct.Note;
    console.log("From Edit Dialog Component", this.editProduct);
 
  }




  onNoClick(): void {
    console.log(this.editProduct);
    this.dialogRef.close();
  }
  updateProduct() {
    this.Value=this.Quantity * this.Price;
    this.editProduct.Quantity = this.Quantity;
    this.editProduct.Note = this.Note;
    this.editProduct.Price = this.Price;
    this.editProduct.Value = this.Value;
  }
  onKeyQuantity(event: any) {
    this.Quantity = event.target.value;
    this.Value = this.Quantity * this.Price;
  }

  onKeyPrice(event: any) {
    this.Price = event.target.value;
    this.Value = this.Quantity * this.Price;
  }

}
