import { AfterViewInit, Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { GroupF_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupF_VM';
import { GroupItemsUnits_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/GroupItemsUnits_VM';
import { ItemDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemDetails_VM';
import { ItemsWithBalance_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/StoreTransDetails/ItemsWithBalance_VM';
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
  GroupF: GroupF_VM[] = [];
  output: GroupF_VM[] = [];
  ItemsOutput: Items_VM[] = [];
  Unitesoutput: Unites_VM[] = [];
  GroupFs: GroupItemsUnits_VM[];
  itemDetails_VM: ItemDetails_VM;
  items_VMs: Items_VM[][];
  itemsFilter: Items_VM[] = [];
  unitesFilter: Unites_VM[] = [];
  items_VM: Items_VM[]=[];
  unites_VMs: Unites_VM[]=[];
  storeTransDetailsDialog: storeTransDetails_VM[] = [];
  dialogCategoryDetails: storeTransDetails_VM[] = [];
  productdetailsDialog: storeTransDetails_VM[] = [];
  ItemsWithBalance: ItemsWithBalance_VM[] = [];
  UniteChanged: boolean = false;
  BringBalance: boolean;
  StoreId: number;
  CurrentBalance: number;
  UniteRate: number=1;
  QuantityNeeded: number;
  BalanceBeforeConvert: number;
  BalanceAfter: number;
  ItemPriceSpec: number;
  AddedRowObjecDone: boolean = false;
  disabelItems = true;
  disabelUnites = true;

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
  BalanceBefore: number;
  ShowPrice: boolean;

  constructor(public TransactionsService: TransactionsService,
    private dialogRef: MatDialogRef<DialogForCategoryComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogForCategory) {
    dialogRef.disableClose = true;
    this.productdetailsDialog = data.productdetails;
    this.BringBalance = data.BringBalance;
    this.StoreId = data.StoreId;
    this.ShowPrice = data.ShowPrice;
    this.ItemPriceSpec = data.ItemPriceSpec;
    console.log("this.hambozo", this.StoreId);
    console.log("this.PriceEffect", this.ShowPrice);
 
    
    this.GroupFs = data.GroupFs;
    console.log("GroupFsFrom Dialog", this.GroupFs);
    console.log("BringBalance From Dialog", this.BringBalance);
    var flags = [];
    var itemFlags = [];

    for (var i = 0; i < this.GroupFs.length; i++) {
      if (flags[this.GroupFs[i].GROUP_ID]) continue;
      flags[this.GroupFs[i].GROUP_ID] = true;
      this.GroupF.push({ GROUP_ID: this.GroupFs[i].GROUP_ID, GROUP_NAME: this.GroupFs[i].GROUP_NAME });
      console.log("Group Dialog", this.GroupF);
      this.selected = this.GroupF[0];
    };

    for (var i = 0; i < this.GroupFs.length; i++) {
      if (itemFlags[this.GroupFs[i].ITEM_ID]) continue;
      itemFlags[this.GroupFs[i].ITEM_ID] = true;
      this.items_VM.push
        ({
        ITEM_ID: this.GroupFs[i].ITEM_ID,
        GROUP_ID: this.GroupFs[i].GROUP_ID,
        ITEM_NAME: this.GroupFs[i].ITEM_NAME,
        ITEM_CODE: this.GroupFs[i].ITEM_CODE,
        BASIC_UNIT: this.GroupFs[i].BASIC_UNIT,
        UNIT_RATE: this.GroupFs[i].UNIT_RATE,
        BRANCH_PRICE: this.GroupFs[i].BRANCH_PRICE,
        DEAL_PRICE: this.GroupFs[i].DEAL_PRICE,
        PURCH_PRICE: this.GroupFs[i].PURCH_PRICE,
        RETAIL_PRICE: this.GroupFs[i].RETAIL_PRICE,
        SALES_PRICE: this.GroupFs[i].SALES_PRICE
      });
      //console.log("items_VM",this.items_VM);
    };

    for (var i = 0; i < this.GroupFs.length; i++) {
      this.unites_VMs.push({ UNIT_ID: this.GroupFs[i].UNIT_ID, ITEM_ID: this.GroupFs[i].ITEM_ID, UNIT_NAME: this.GroupFs[i].UNIT_NAME, UNIT_RATE: this.GroupFs[i].UNIT_RATE });
    };

    if (this.productdetailsDialog.length > 0) {
      this.storeTransDetailsDialog = [];
      for (var i = 0; i < this.productdetailsDialog.length; i++) {
        this.storeTransDetailsDialog.push({
          qty: this.productdetailsDialog[i].qty,
          unitId: this.productdetailsDialog[i].unitId,
          itemId: this.productdetailsDialog[i].itemId,
          totalo: this.productdetailsDialog[i].totalo,
          item_Name: this.productdetailsDialog[i].item_Name,
          unit_Name: this.productdetailsDialog[i].unit_Name,
          groupF_Id: this.productdetailsDialog[i].groupF_Id,
          groupF_Name: this.productdetailsDialog[i].groupF_Name,
          storeTrnsOId: this.productdetailsDialog[i].storeTrnsOId,
          unitPrice: this.productdetailsDialog[i].unitPrice,
        });
      }
      
      this.productdetailsDialog = [];
  
    }
  }
 

  ngOnInit() {
    if (this.BringBalance == true) {
    this.TransactionsService.GetAllItemsBalance().subscribe(
      res => {
        console.log("GetAllItemsBalance", res);
        this.ItemsWithBalance = res;
        console.log("GetAllItemsBalance", this.ItemsWithBalance);
      }
      );
    }
    console.log("After this.unites_VMs.length", this.unites_VMs.length);
    console.log("After this.unites_VMs.length", this.unites_VMs);
  };
  

  GroupfChange(GroupId: number) {
    this.disabelItems = false;

    //يوم الجمعه
     this.ItemId = undefined;
    this.UniteId = undefined;
    this.BalanceBefore = undefined;
    this.totalo = undefined;

    this.Group = this.GroupFs.filter(s => s.GROUP_ID == GroupId)[0];
    console.log("Group", this.Group);
    this.itemsFilter = this.items_VM.filter(s => s.GROUP_ID == GroupId);

  };


  ItemsChange(ItemId: number) {
    this.disabelUnites = false;
    this.unitesFilter = this.unites_VMs.filter(s => s.ITEM_ID == ItemId);
    this.Item = this.items_VM.filter(s => s.ITEM_ID == ItemId)[0];
    var BasicUnite: number;
    var BasicUniteExist: number;
     BasicUnite= this.Item.BASIC_UNIT;
    console.log("BasicUnite", BasicUnite);

   
    try
    {
      BasicUniteExist = this.unitesFilter.filter(s => s.UNIT_ID == BasicUnite)[0].UNIT_ID;
      console.log("BasicUniteExist", BasicUniteExist);
      if (BasicUniteExist != undefined)
      {
        this.UniteId = BasicUnite;
      }
        
        console.log("BasicUnite", BasicUnite);
      
    } catch (e)
    {
      this.UniteId = undefined;
    }
    this.Unite = this.unites_VMs.filter(s => s.UNIT_ID == this.UniteId)[0];
    console.log("item selected", this.Item);
    console.log(" UniteId", this.UniteId);

    this.UniteRate = this.unitesFilter.filter(s => s.UNIT_ID == this.UniteId)[0].UNIT_RATE;
    console.log(" this.UniteRate from item change", this.UniteRate);

    //Get Balance for selected item
    if (this.BringBalance == true) {

      try {
        console.log("this.StoreId", this.StoreId);
        console.log("this.ItemId", this.ItemId);
        console.log(this.ItemsWithBalance.filter(s => s.ITEM_ID == ItemId && s.STORE_ID == this.StoreId));
        this.CurrentBalance = this.ItemsWithBalance.filter(s => s.ITEM_ID == ItemId && s.STORE_ID == this.StoreId)[0].QTY;

        console.log("There is need to calculate balance", this.CurrentBalance);
        this.BalanceBefore = this.CurrentBalance;
        console.log("BalanceBefore", this.BalanceBefore);
      }
      catch (e) {
        this.SetInputValuesToDefalut();
        alert("هذا الصنف غير موجود في ذلك المخزن");

      }
    }


    //specify which price will viewd
    if (this.ShowPrice == true)
    {
      this.ViewSpecficPrice();
    }
    if (this.ItemPriceSpec == 6 || this.ItemPriceSpec == 7)
    {
      this.ShowPrice == false;
    }
  };


  UnitesChange(UniteId: number) {

    var OldUnit: number = this.UniteRate;
    this.Unite = this.unites_VMs.filter(s => s.UNIT_ID == UniteId)[0];
    console.log("selected unite",this.Unite);
    //Get UniteRate in Bring Balance case
    this.UniteRate = this.unitesFilter.filter(s => s.UNIT_ID == UniteId)[0].UNIT_RATE;
    console.log(" this.UniteRate", this.UniteRate);
    try {
      this.BalanceBefore = (this.BalanceBefore * OldUnit / this.UniteRate);
      this.BalanceAfter = (this.BalanceAfter * OldUnit / this.UniteRate);
      if (this.quantity != undefined)
        this.quantity = (this.quantity * OldUnit / this.UniteRate);
      else (this.QuantityNeeded != undefined)
        this.QuantityNeeded = (this.QuantityNeeded *OldUnit / this.UniteRate);
      
    } catch (e) {

    }
  }


  onKeyQuantity(event: any) {

    this.totalo = event.target.value * this.unitPrice;
    this.QuantityNeeded = event.target.value ;
    //console.log("QuantityNeeded", this.QuantityNeeded);
    //try {

    //  if (this.Index > -1 && this.storeTransDetailsDialog[this.Index].storeTrnsOId != undefined) {
    //    this.CalculateRestFullBalance();
    //  }
    //} catch (e) {
    //  this.ConvertCurrentBalance();
    //  this.CalculateRestFullBalance();
    //}
    if (this.QuantityNeeded == undefined) {
      this.QuantityNeeded = 0;
    }
    this.BalanceAfter = this.BalanceBefore - this.QuantityNeeded;
  };


  onKeyPrice(event: any, i: number) {
    this.totalo = event.target.value * this.quantity;
  };


  SaveOneRow() {
    this.AddedRowObjecDone = true;
    //need to validate
    //Editing mode
    //case Edit and balance be in considered
    if (this.Index >= 0)
    {
      if (this.BringBalance == true)
      {
        if (confirm(`تأكيد عملية التعديل...؟`))
        {
          if (this.QuantityNeeded > this.CurrentBalance)
          {
            alert("االكمية المطلوبة غير متاحة");
            return;
          }
        }
      }
     
        this.storeTransDetailsDialog[this.Index].groupF_Id = this.GroupId;
        this.storeTransDetailsDialog[this.Index].groupF_Name = this.GroupF.filter(s => s.GROUP_ID == this.GroupId)[0].GROUP_NAME;
        this.storeTransDetailsDialog[this.Index].unitId = this.UniteId;
        this.storeTransDetailsDialog[this.Index].unit_Name = this.Unite.UNIT_NAME;
        this.storeTransDetailsDialog[this.Index].itemId = this.ItemId;
        this.storeTransDetailsDialog[this.Index].item_Name = this.Item.ITEM_NAME;
        this.storeTransDetailsDialog[this.Index].qty = this.quantity;
        this.storeTransDetailsDialog[this.Index].totalo = this.totalo;
        this.storeTransDetailsDialog[this.Index].unitPrice = this.unitPrice;
        this.Index = -1;
      
    }
    //Add 
    else
    {
      if (this.BringBalance == true)
      {
        if (this.QuantityNeeded > this.CurrentBalance)
        {
          alert("االكمية المطلوبة غير متاحة");
          return;
        }
        
      }
     
        this.storeTransDetailsDialog.push({
          groupF_Id: this.Group.GROUP_ID,
          groupF_Name: this.Group.GROUP_NAME,
          itemId: this.Item.ITEM_ID,
          item_Name: this.Item.ITEM_NAME,
          unitId: this.Unite.UNIT_ID,
          unit_Name: this.Unite.UNIT_NAME,
          qty: this.quantity,
          unitPrice: this.unitPrice,
          totalo: 0,
        });
      

    }
    
   
    console.log("storeTransDetails_VM from dialog save", this.storeTransDetailsDialog);
    console.log("productdetails from dialog save", this.productdetailsDialog);

    //set to default values
    this.SetInputValuesToDefalut();
  };


  EditProduct(i: number) {
    console.log("transaction", i);
    this.Index = i;
    this.disabelUnites = true;
    //to view these values in dropDowns
    this.GroupId = this.storeTransDetailsDialog[i].groupF_Id;
    console.log("this.GroupId", this.GroupId);
    this.GroupfChange(this.GroupId);
    this.ItemId = this.storeTransDetailsDialog[i].itemId;
    this.ItemsChange(this.ItemId);
    this.UniteId = this.storeTransDetailsDialog[i].unitId;
    this.quantity = this.storeTransDetailsDialog[i].qty;
    this.totalo = this.storeTransDetailsDialog[i].totalo;
    this.unitPrice = this.storeTransDetailsDialog[i].unitPrice;
    //to set new values
    if (this.BringBalance == true)
    {
      try {
        this.CurrentBalance = this.ItemsWithBalance.filter(s => s.ITEM_ID == this.ItemId && s.STORE_ID == this.StoreId)[0].QTY;
        this.UniteRate = this.unitesFilter.filter(s => s.UNIT_ID == this.UniteId)[0].UNIT_RATE;
        try {
          if (this.storeTransDetailsDialog[this.Index].storeTrnsOId != undefined) {
            this.ConvertCurrentBalanceInEditMode();
          } else {
            this.BalanceBefore = this.CurrentBalance / this.UniteRate;
          }
        } catch (e) { }

        this.CalculateRestFullBalance();

        if (this.CurrentBalance <= 0) {

          this.SetInputValuesToDefalut();
          alert("لا يوجد رصيد لهذا الصنف");
        }

      }
      catch (e) {
        alert("هذا الصنف غير موجود في ذلك المخزن");
        this.SetInputValuesToDefalut();
      }
    }
  }


  saveChanges() {
    console.log("this.productdetailsDialog", this.productdetailsDialog);
    console.log("this.storeTransDetailsDialog", this.storeTransDetailsDialog);


    for (var i = 0; i < this.storeTransDetailsDialog.length; i++) {
      this.productdetailsDialog.push({
        qty: this.storeTransDetailsDialog[i].qty,
        unitId: this.storeTransDetailsDialog[i].unitId,
        itemId: this.storeTransDetailsDialog[i].itemId,
        totalo: this.storeTransDetailsDialog[i].totalo,
        item_Name: this.storeTransDetailsDialog[i].item_Name,
        unit_Name: this.storeTransDetailsDialog[i].unit_Name,
        groupF_Id: this.storeTransDetailsDialog[i].groupF_Id,
        groupF_Name: this.GroupF.filter(s => s.GROUP_ID == (this.storeTransDetailsDialog[i].groupF_Id))[0].GROUP_NAME,
        storeTrnsOId: this.storeTransDetailsDialog[i].storeTrnsOId,
        unitPrice: this.storeTransDetailsDialog[i].unitPrice
      });
    }
    this.productdetailsDialog = this.storeTransDetailsDialog;
    console.log("this.productdetailsDialog from save changes", this.productdetailsDialog);
  }


  onNoClick(): void {

    this.dialogRef.close();
  };


  RemoveRow(i: number) {
    if (confirm(`سيتم حذف الصنف ${this.storeTransDetailsDialog[i].item_Name} ؟؟`)) {
      console.log("clicked");
      this.storeTransDetailsDialog.splice(i, 1);
      console.log(this.storeTransDetailsDialog)
      this.AddedRowObjecDone = true;
    }
  };


  //Pure Function
  ConvertCurrentBalance() {
    console.log("ConvertCurrentBalance");
    var tempCurrentBalance: number = this.CurrentBalance;
    this.BalanceBefore = tempCurrentBalance;
    //mean change in unite
    //in edit mode
      //check Quatity change
    //in create new mode
    try
    {
      this.BalanceBeforeConvert = this.BalanceBefore / (this.UniteRate);
      this.BalanceBefore = this.BalanceBeforeConvert;
    }
    catch (e) { this.BalanceBefore = this.CurrentBalance; }
  };

  ConvertCurrentBalanceInEditMode() {
    console.log("ConvertCurrentBalanceInEditMode");
    //when click without any changes
    this.BalanceBefore = (((this.quantity * +this.UniteRate) + this.CurrentBalance) / this.UniteRate);
    //when change in quantuty

  }


  //Pure Function
  CalculateRestFullBalance() {

    try {

      if ((this.QuantityNeeded != undefined) && this.QuantityNeeded != this.quantity) {
        this.BalanceAfter = (this.BalanceBefore) - (this.QuantityNeeded);
        console.log(this.BalanceAfter, "this.BalanceAfter");
      }
      else {
        this.BalanceAfter = (this.BalanceBefore) - (this.quantity);
        console.log(this.quantity, "this.quantity");
        console.log(this.BalanceAfter, "this.BalanceAfter");
      }
    } catch (e)
    {
      this.BalanceAfter = (this.BalanceBefore) - (this.quantity);
      console.log(this.BalanceAfter, "this.BalanceAfter");
    }
}

  //Pure Function
  SetInputValuesToDefalut() {
    this.GroupId = undefined;
    this.ItemId = undefined;
    this.UniteId = undefined;
    this.quantity = undefined;
    this.QuantityNeeded = undefined;
    this.unitPrice = undefined;
    this.totalo = undefined;
    this.BalanceBefore = undefined;
    this.CurrentBalance = undefined;
    this.BalanceBeforeConvert = undefined;
    this.BalanceAfter = undefined;
  };
  //Determine which price will viewed
  ViewSpecficPrice()
  {
    if (this.ItemPriceSpec == 1) {
      this.unitPrice = this.Item.PURCH_PRICE;
    } else if (this.ItemPriceSpec == 2) {
      this.unitPrice = this.Item.DEAL_PRICE;
    }
    else if (this.ItemPriceSpec == 3) {
      this.unitPrice = this.Item.SALES_PRICE;
    }
    else if (this.ItemPriceSpec == 4) {
      this.unitPrice = this.Item.BRANCH_PRICE;
    }
    else if (this.ItemPriceSpec == 5) {
      console.log("avarege price not calculated yet", this.unitPrice);
    } 
  }

}
