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
  unitesFilter: Unites_VM[] = [];
  items_VM: Items_VM[]=[];
  unites_VMs: Unites_VM[]=[];
  storeTransDetailsDialog: storeTransDetails_VM[] = [];
  dialogCategoryDetails: storeTransDetails_VM[] = [];
  productdetailsDialog: storeTransDetails_VM[]=[];

  GroupFChanged: boolean = false;
  ItemChanged: boolean = false;
  EditingClick: boolean = false;
  AddedRowObjecDone: boolean = false;
  

  //two way binding
  quantity: number;
  unitPrice: number;
  totalo: number;
  Group: GroupF_VM;
  Item: Items_VM;
  Unite: Unites_VM;
  GroupId: number;
  ItemId: number;
  UniteId: number;
  Index: number;
  selected: any;
 

  constructor(public TransactionsService: TransactionsService,
    private dialogRef: MatDialogRef<DialogForCategoryComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogForCategory) {
    dialogRef.disableClose = true;
    this.productdetailsDialog = data.productdetails;
    this.GroupFs = data.GroupFs;
    console.log("GroupFsFrom Dialog", this.GroupFs);

    if (this.productdetailsDialog.length > 0) {

      for (var i = 0; i < this.productdetailsDialog.length; i++) {
        this.storeTransDetailsDialog.push({
          qty: this.productdetailsDialog[i].qty, unitId: this.productdetailsDialog[i].unitId, itemId: this.productdetailsDialog[i].itemId, totalo: this.productdetailsDialog[i].totalo,
          item_Name: this.productdetailsDialog[i].item_Name, unit_Name: this.productdetailsDialog[i].unit_Name, groupF_Id: this.productdetailsDialog[i].groupF_Id,
          storeTrnsOId: this.productdetailsDialog[i].storeTrnsOId, unitPrice: this.productdetailsDialog[i].unitPrice
        });
      }
      this.productdetailsDialog = [];
    }
  }

  ngOnInit() {
    //Second Way
    for (var i = 0; i < this.GroupFs.length; i++) {
      this.GroupF.push({ GroupF_Id: this.GroupFs[i].GroupF_Id, Aname: this.GroupFs[i].Aname });
      console.log("Group Dialog", this.GroupF);
      this.selected = this.GroupF[0];
     
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
  };

  GroupfChange(GroupId: number) {
    this.GroupFChanged = true;
    this.EditingClick = false;

    //يوم الجمعه
     this.ItemId = undefined;
     this.UniteId = undefined;

    this.Group = this.GroupFs.filter(s => s.GroupF_Id == GroupId)[0];
    console.log("Group", this.Group);
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
    this.ItemChanged = true;
    this.EditingClick = false;
    this.unitesFilter = this.unites_VMs.filter(s => s.itemId == ItemId);
    this.Item = this.items_VM.filter(s => s.itemId == ItemId)[0];
    console.log("item selected",this.Item);

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

  UnitesChange(UniteId: number) {
    this.Unite = this.unites_VMs.filter(s => s.uniteId == UniteId)[0];
    console.log("selected unite",this.Unite);
    //this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
  }

  onKeyQuantity(event: any) {
  //  this.storeTransDetails_VM[i].qty = event.target.value;
    //  this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
    this.totalo = event.target.value * this.unitPrice;
  };

  onKeyPrice(event: any, i: number) {
    //this.storeTransDetails_VM[i].unitPrice = event.target.value;
    //this.storeTransDetails_VM[i].totalo = this.storeTransDetails_VM[i].qty * this.storeTransDetails_VM[i].unitPrice;
    this.totalo = event.target.value * this.quantity;
  };
  SaveOneRow() {
    this.AddedRowObjecDone = true;
    //need to validate
    //Editing mode
    if (this.Index >= 0) {
      if (confirm(`تأكيد عملية التعديل...؟`)){
        console.log(this.Index)
        this.storeTransDetailsDialog[this.Index].groupF_Id = this.GroupId;
        this.storeTransDetailsDialog[this.Index].unitId = this.UniteId;
        this.storeTransDetailsDialog[this.Index].unit_Name = this.Unite.name;
        this.storeTransDetailsDialog[this.Index].itemId = this.ItemId;
        this.storeTransDetailsDialog[this.Index].item_Name = this.Item.name;
        this.storeTransDetailsDialog[this.Index].qty = this.quantity;
        this.storeTransDetailsDialog[this.Index].totalo = this.totalo;
        this.storeTransDetailsDialog[this.Index].unitPrice = this.unitPrice;
        this.Index = -1;
      }
    } else {
     
      this.storeTransDetailsDialog.push({
        groupF_Id: this.Group.GroupF_Id, itemId: this.Item.itemId, item_Name: this.Item.name, unitId: this.Unite.uniteId,
        unit_Name: this.Unite.name, qty: this.quantity, unitPrice: this.unitPrice, totalo: this.totalo
      });
     
    }
    
   
    console.log("storeTransDetails_VM from dialog save", this.storeTransDetailsDialog);
    console.log("productdetails from dialog save", this.productdetailsDialog);
    //this.EditingClick = true;
    //this.GroupFChanged = false;
    //this.ItemChanged = false;

    //set to default values
    this.GroupId = undefined;
    this.ItemId = undefined;
    this.UniteId = undefined;
    this.quantity = undefined;
    this.unitPrice = undefined;
    
  }

  EditProduct(i: number) {
    console.log("transaction", i);
    this.Index = i;
    this.EditingClick = true;
    this.ItemChanged = false;
    this.GroupFChanged = false;
    //to view these values in dropDowns
    this.GroupId = this.storeTransDetailsDialog[i].groupF_Id;
    console.log("this.GroupId", this.GroupId);
    this.ItemId = this.storeTransDetailsDialog[i].itemId;
    this.UniteId = this.storeTransDetailsDialog[i].unitId;
    this.quantity = this.storeTransDetailsDialog[i].qty;
    this.totalo = this.storeTransDetailsDialog[i].totalo;
    this.unitPrice = this.storeTransDetailsDialog[i].unitPrice;
    //to set new values

    
  }
  saveChanges() {
    console.log("this.productdetailsDialog", this.productdetailsDialog);
    console.log("this.storeTransDetailsDialog", this.storeTransDetailsDialog);
    //var temp: storeTransDetails_VM[];
    //temp = this.storeTransDetailsDialog;
    //console.log(temp);
    //this.productdetailsDialog = temp;
    for (var i = 0; i < this.storeTransDetailsDialog.length; i++) {
      this.productdetailsDialog.push({
        qty: this.storeTransDetailsDialog[i].qty, unitId: this.storeTransDetailsDialog[i].unitId, itemId: this.storeTransDetailsDialog[i].itemId, totalo: this.storeTransDetailsDialog[i].totalo,
        item_Name: this.storeTransDetailsDialog[i].item_Name, unit_Name: this.storeTransDetailsDialog[i].unit_Name, groupF_Id: this.storeTransDetailsDialog[i].groupF_Id, storeTrnsOId: this.storeTransDetailsDialog[i].storeTrnsOId
      });
    }
    this.productdetailsDialog = this.storeTransDetailsDialog;
    console.log("this.productdetailsDialog from save changes", this.productdetailsDialog);
  }

  onNoClick(): void {
    //this.storeTransDetails_VM = this.data.dialogCategoryDetails;
    //console.log("from Dialog Category close",this.storeTransDetails_VM);
    //this.productdetailsDialog = this.storeTransDetailsDialog.filter(s => s.tempAdded == false);

    this.dialogRef.close();
  };


  RemoveRow(i: number){
    console.log("clicked");
    this.storeTransDetailsDialog.splice(i, 1);
    console.log(this.storeTransDetailsDialog)
  };


}
