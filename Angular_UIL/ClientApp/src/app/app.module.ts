import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DateTimePickerModule } from '@syncfusion/ej2-angular-calendars';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { DataTablesModule } from 'angular-datatables';
import { AllTransactionsComponent } from './all-transactions/all-transactions.component';
import { CreateTransactionComponent } from './create-transaction/create-transaction.component';
import { TransactionsService } from './services/transactions.service';
import { TransactionsListComponent } from './transactions-list/transactions-list.component';
import { TransactionSpecificComponent } from './transaction-specific/transaction-specific.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    AllTransactionsComponent,
    CreateTransactionComponent,
    TransactionsListComponent,
    TransactionSpecificComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DataTablesModule,
    DateTimePickerModule,
    RouterModule.forRoot([
      { path: '', component: TransactionsListComponent, pathMatch: 'full' },
      { path: 'all-transactions/:id', component: AllTransactionsComponent },
      { path: 'create-transaction', component: CreateTransactionComponent },
      { path: 'transaction-list', component: TransactionsListComponent },
      { path: 'transaction-specific/:id', component: TransactionSpecificComponent },
    ])
  ],
  providers: [TransactionsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
