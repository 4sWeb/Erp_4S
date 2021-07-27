import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DateTimePickerModule } from '@syncfusion/ej2-angular-calendars';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DataTablesModule } from 'angular-datatables';
import { AllTransactionsComponent } from './all-transactions/all-transactions.component';
import { CreateTransactionComponent } from './create-transaction/create-transaction.component';
import { TransactionsService } from './services/transactions.service';
import { TransactionsListComponent } from './transactions-list/transactions-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AllTransactionsComponent,
    CreateTransactionComponent,
    TransactionsListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DataTablesModule,
    DateTimePickerModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'all-transactions/:id', component: AllTransactionsComponent },
      { path: 'create-transaction', component: CreateTransactionComponent },
      { path: 'transaction-list', component: TransactionsListComponent }
    ])
  ],
  providers: [TransactionsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
