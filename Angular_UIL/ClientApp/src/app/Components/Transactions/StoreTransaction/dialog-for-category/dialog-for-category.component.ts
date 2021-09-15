import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { GroupF_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupF_VM';
import { ItemDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemDetails_VM';
import { Items_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Items_VM';
import { Unites_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Unites_VM';
import { storeTransDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';
import { DialogForCategory } from '../transaction-specific/transaction-specific.component';

@Component({
  selector: 'app-dialog-for-category',
  templateUrl: './dialog-for-category.component.html',
  styleUrls: ['./dialog-for-category.component.css']
})
export class DialogForCategoryComponent implements OnInit {
  GroupF: GroupF_VM[]=[];
  GroupFs: GroupF_VM[];
  itemDetails_VM: ItemDetails_VM;
  items_VMs: Items_VM[][];
  itemsFilter: Items_VM[] = [];
  items_VM: Items_VM[]=[];
  unites_VMs: Unites_VM[]=[];
  storeTransDetails_VM: storeTransDetails_VM[] = [];
  dialogCategoryDetails: storeTransDetails_VM[] = [];
  productdetails: storeTransDetails_VM[];

  GroupFChanged: boolean = false;
  ItemChanged: boolean;
  constructor(public TransactionsService: TransactionsService,
    private dialogRef: MatDialogRef<DialogForCategoryComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogForCategory) {
    dialogRef.disableClose = true;
    this.productdetails = data.productdetails;
    this.GroupFs = data.GroupFs;
    console.log("GroupFsFrom Dialog", this.GroupFs);

    if (this.productdetails.length>0) {
    for (var i = 0; i < this.productdetails.length; i++) {
      this.storeTransDetails_VM.push({ qty: this.productdetails[i].qty, unitId: this.productdetails[i].unitId, itemId: this.productdetails[i].itemId, totalo: this.productdetails[i].totalo })
    }
    }
  }

  ngOnInit() {
    //Second Way
    for (var i = 0; i < this.GroupFs.length; i++) {
      this.GroupF.push({ GroupF_Id: this.GroupFs[i].GroupF_Id, Aname: this.GroupFs[i].Aname });
      console.log("Group Dialog",this.GroupF);
     
    }
    for (var i = 0; i < this.GroupFs.length; i++) {
      for (var j = 0; j < this.GroupFs[i].items_VM.length;j++) {
        this.items_VM.push({ itemId: this.GroupFs[i].items_VM[j].itemId, groupId: this.GroupFs[i].GroupF_Id, name: this.GroupFs[i].items_VM[j].name });
      }
      console.log("items_VM", this.items_VM);
    }
    for (var i = 0; i < this.GroupFs.length; i++) {
      for (var j = 0; j < this.GroupFs[i].items_VM.length; j++) {
        for (var k = 0; k < this.GroupFs[i].items_VM[j].unites_VM.length;k++) {
        this.unites_VMs.push({ uniteId: this.GroupFs[i].items_VM[j].unites_VM[k].uniteId, itemId: this.GroupFs[i].items_VM[j].itemId, name: this.GroupFs[i].items_VM[j].unites_VM[k].name })

        }
      }
    }

    for (var i = 0; i < 5; i++) {
      this.storeTransDetails_VM.push({ qty: 0, unitPrice:0, unitId: undefined, groupF_Id: 281, itemId: undefined ,totalo:0});
    }
    //this.TransactionsService.getAllGroups().subscribe(
    //  (data) => {
    //    console.log("GroupFFromDialog", data);
    //    this.GroupF = data;
    //  }
    //);
  }
  GroupfChange(GroupId: number) {
    this.GroupFChanged = true;
    //console.log("GroupId", id);
    
    this.itemsFilter = this.items_VM.filter(s => s.groupId == GroupId);

    //this.TransactionsService.getItemsDetails(id).subscribe(
    //  (data) => {
    //    console.log("ItemDetails from Dialog Cat", data);
    //    this.itemDetails_VM = data;
    //    this.items_VM = this.itemDetails_VM.items_VM;
        
    //    this.unites_VMs = this.itemDetails_VM.unites_VM;
    //    this.storeTransDetails_VM[i].itemId = this.itemDetails_VM.items_VM[0].itemId;
    //    this.storeTransDetails_VM[i].unitId = this.itemDetails_VM.unites_VM[0].uniteId;
    //  }
    //);
  };

  ItemsChange(ItemId: number) {
    return this.unites_VMs.filter(s => s.itemId == ItemId);
    //console.log("item id",id);
    //this.TransactionsService.getUnitesDetails(id).subscribe(
    //  (data) => {
    //    console.log("unites", data);
    //    this.unites_VMs = data;
    //    this.ItemChanged = true;
    //    this.storeTransDetails_VM[i].unitId = this.unites_VMs[0].uniteId;
    //  }
    //);
  };

  UnitesChange(i: number) {
    this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
  }

  onKeyQuantity(event: any, i: number) {
    this.storeTransDetails_VM[i].qty = event.target.value;
    this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
  };

  onKeyPrice(event: any, i: number) {
    this.storeTransDetails_VM[i].unitPrice = event.target.value;
    this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
  };

  onNoClick(): void {
    //this.storeTransDetails_VM = this.data.dialogCategoryDetails;
    //console.log("from Dialog Category close",this.storeTransDetails_VM);
    this.dialogRef.close();
  };
}
