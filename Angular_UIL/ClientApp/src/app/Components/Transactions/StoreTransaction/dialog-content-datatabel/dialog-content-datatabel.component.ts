import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { from, Subject } from 'rxjs';
import { storeTransDetails_VM } from '../../../../models/Transactions/StoreTransaction/SaveStoreTransaction/storeTransDetails_VM';
import { DependancyProduct } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/dependancy-product';
import { TransactionsDetails } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/transactions-details';
import { TransactionsService } from '../../../../services/StoreTransaction/transactions.service';
import { DialogData } from '../transaction-specific/transaction-specific.component';
import { FromType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/from-type'
import { ToType } from '../../../../models/Transactions/StoreTransaction/TransactionSpecification/to-type'
import { SharingDataService } from '../../../../services/SharingData/sharing-data.service';
@Component({
  selector: 'app-dialog-content-datatabel',
  templateUrl: './dialog-content-datatabel.component.html',
  styleUrls: ['./dialog-content-datatabel.component.css']
})
export class DialogContentDatatabelComponent implements OnInit, OnDestroy {


  dtOptions: DataTables.Settings = {};
  dtTrigger: Subject<any> = new Subject<any>();
  selectedTransaction: number;
  TransactionsDetails?: TransactionsDetails[];

  checkedTransactionsMain?: TransactionsDetails[];

  checkedTransactions?: number[];
  checkedTransactionsIds?: number[];
  DependancyProduct?: storeTransDetails_VM[];

  TO_TypeName: string ;
  From_TypeName: string;
  FromFilter: number;
  ToFilter: number;
  GetItem: number;

  From_Type: FromType[];
  

  constructor(public TransactionsService: TransactionsService, public SharingDataService: SharingDataService,
    private dialogRef: MatDialogRef<DialogContentDatatabelComponent>,
    @Inject(MAT_DIALOG_DATA)public data:DialogData) {

    dialogRef.disableClose = true;
    this.selectedTransaction = data.selectedTransaction;
    this.checkedTransactionsIds = data.checkedTransactionsIds;
    this.checkedTransactionsMain = data.checkedTransactionsMain;
    this.FromFilter = data.FromFilter;
    this.ToFilter = data.ToFilter;
    this.GetItem = data.GetItem;
    console.log("from Dialoogggg component", this.selectedTransaction);
    console.log("from Dialoogggg component2", this.checkedTransactionsIds);
    console.log("from Dialoogggg component2", this.checkedTransactionsMain);
  }



  ngOnInit() {

    this.checkedTransactions = new Array<number>();
    this.checkedTransactionsIds = new Array<number>();
    this.checkedTransactionsMain = new Array<TransactionsDetails>();

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5
    };

    this.TransactionsService.getTransactionsByDepID(this.selectedTransaction).subscribe(
      (response) => {
        console.log("selected id transaction", this.selectedTransaction);
        this.TransactionsDetails = response;
        console.log("this.TransactionsDetails", this.TransactionsDetails);

        //Fiter From 
        if (this.FromFilter == 1) {
          console.log("gettoStoreAllCodesId",this.SharingDataService.getfromStoreAllCodesId());
          if (this.SharingDataService.getfromStoreAllCodesId() != undefined)
          {
            var temp = this.TransactionsDetails.filter(s => s.From_StoreAllcodesId == this.SharingDataService.getfromStoreAllCodesId());
            this.TransactionsDetails = temp;
            console.log("After Filteration", this.TransactionsDetails);
          }
      
        }

         if (this.FromFilter == 2) {
          if (this.SharingDataService.getfromStoreAllCodesId() != undefined) {
            var temp = this.TransactionsDetails.filter(s => s.To_StoreAllcodesId == this.SharingDataService.getfromStoreAllCodesId());
            this.TransactionsDetails = temp;
            console.log("After Filteration", this.TransactionsDetails);
          }
        }

        //Filter To
        if (this.ToFilter == 1) {
          if (this.SharingDataService.gettoStoreAllCodesId() != undefined) {
            var temp = this.TransactionsDetails.filter(s => s.From_StoreAllcodesId == this.SharingDataService.gettoStoreAllCodesId());
            this.TransactionsDetails = temp;
            console.log("After Filteration", this.TransactionsDetails);
          }

        }

         if (this.ToFilter == 2) {
          if (this.SharingDataService.gettoStoreAllCodesId() != undefined) {
            var temp = this.TransactionsDetails.filter(s => s.To_StoreAllcodesId == this.SharingDataService.gettoStoreAllCodesId());
            this.TransactionsDetails = temp;
            console.log("After Filteration", this.TransactionsDetails);
          }
        }



       
        for (var i = 0; i < this.TransactionsDetails.length; i++)
        {
          try {
            this.From_TypeName = this.TransactionsDetails[i].From_Type[0].TYPE_NAME;

          } catch (e) { this.From_TypeName = ""; }
        }
       

       
        for (var i = 0; i < this.TransactionsDetails.length; i++) {
          try {
            this.TO_TypeName = this.TransactionsDetails[i].To_Type[0].TYPE_NAME;
          } catch (e) { this.TO_TypeName = ""; }
        } 
        this.dtTrigger.next();
      });
    this.dtTrigger.next();
  }

  getAllCheckedTransId(e: any, id: number) {
    if (e.target.checked) {
      console.log(id + "checked");
      //var listofrows = $('#tabel1').DataTable().rows({ selected: true }).data().toArray();
      this.checkedTransactions.push(id);
    } else {
      console.log(id + "unchecked");
      this.checkedTransactions = this.checkedTransactions.filter(m => m != id);
    }
    
    //console.log("listOfRows", listofrows)
    console.log("checkedTransactions",this.checkedTransactions);
  }



  getAllCheckedTransaction(e: any, trns: TransactionsDetails,id:number) {
    if (e.target.checked) {
      console.log(trns + "checked");
      console.log(this.checkedTransactionsMain.push(trns));
      this.checkedTransactionsIds.push(id);

    } else {
      console.log(trns + "unchecked");
      this.checkedTransactionsMain = this.checkedTransactionsMain.filter(m => m != trns);
      this.checkedTransactionsIds = this.checkedTransactionsIds.filter(m => m != id);
      

    }

    console.log("checkedTransactionsItem", this.checkedTransactionsMain);
  
    console.log("checkedTransactionsIds", this.checkedTransactionsIds);
  }

  onNoClick(): void {
    this.dialogRef.close();
    //console.log("checkedTransactions", this.checkedTransactions);
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

}
