import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DateTimePickerModule } from '@syncfusion/ej2-angular-calendars';
import { MatDialogModule } from '@angular/material/dialog';
import { AppComponent } from './app.component';
import { DataTablesModule } from 'angular-datatables';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
/////////////////////////*********************Services**************//////////////////////////////////////
import { TransactionsService } from './services/StoreTransaction/transactions.service';

//////////////////////////******************Components**************/////////////////////////////////////
import { NavMenuComponent } from './Components/nav-menu/nav-menu.component';
import { AllTransactionsComponent } from './Components/Transactions/StoreTransaction/all-transactions/all-transactions.component';
import { CreateTransactionComponent } from './Components/Transactions/StoreTransaction/create-transaction/create-transaction.component';
import { TransactionsListComponent } from './Components/Transactions/transactions-list/transactions-list.component';
import { TransactionSpecificComponent } from './Components/Transactions/StoreTransaction/transaction-specific/transaction-specific.component';
import { DialogContentDatatabelComponent } from './Components/Transactions/StoreTransaction/dialog-content-datatabel/dialog-content-datatabel.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    AllTransactionsComponent,
    CreateTransactionComponent,
    TransactionsListComponent,
    TransactionSpecificComponent,
    DialogContentDatatabelComponent,
  ],
  entryComponents: [DialogContentDatatabelComponent],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DataTablesModule,
    DateTimePickerModule,
    MatDialogModule,
    MatInputModule,
    MatFormFieldModule,
    RouterModule.forRoot([
      { path: '', component: TransactionsListComponent, pathMatch: 'full' },
      { path: 'all-transactions/:id', component: AllTransactionsComponent },
      { path: 'create-transaction', component: CreateTransactionComponent },
      { path: 'transaction-list', component: TransactionsListComponent },
      { path: 'transaction-specific/:id/:userId', component: TransactionSpecificComponent },
    ]),
    BrowserAnimationsModule
  ],
  providers: [TransactionsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
