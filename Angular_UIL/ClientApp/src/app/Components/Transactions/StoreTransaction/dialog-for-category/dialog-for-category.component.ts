import { Component, OnInit } from '@angular/core';
import { GroupF_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupF_VM';
import { ItemDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemDetails_VM';
import { Items_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Items_VM';
import { Unites_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/Unites_VM';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';

@Component({
  selector: 'app-dialog-for-category',
  templateUrl: './dialog-for-category.component.html',
  styleUrls: ['./dialog-for-category.component.css']
})
export class DialogForCategoryComponent implements OnInit {
  GroupF: GroupF_VM[];
  itemDetails_VM: ItemDetails_VM;
  Items_VMs: Items_VM[];
  unites_VMs: Unites_VM[];
  constructor(public TransactionsService:TransactionsService) { }

  ngOnInit() {
    this.TransactionsService.getAllGroups().subscribe(
      (data) => {
        console.log("GroupFFromDialog", data);
        this.GroupF = data;
      }
    );
  }
  GroupfChange(id: number) {

    this.TransactionsService.getItemsDetails(id).subscribe(
      (data) => {
        
        this.itemDetails_VM = data;
        this.Items_VMs = this.itemDetails_VM.items_VM;
        this.unites_VMs = this.itemDetails_VM.unites_VM;
        //this.storeTransDetails_VM[0].itemId = this.itemDetails_VM.items_VM[0].itemId;
        //this.storeTransDetails_VM[0].unitId = this.itemDetails_VM.unites_VM[0].uniteId;
      }
    );
  }

  ItemsChange(id: number) {
    this.TransactionsService.getUnitesDetails(id).subscribe(
      (data) => {
        console.log("unites", data);
        this.unites_VMs = data;
        //this.storeTransDetails_VM[0].unitId = this.unites_VMs[0].uniteId;
      }
    )

  }

}
