import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DateTimePickerModule } from '@syncfusion/ej2-angular-calendars';
import { MatDialogModule } from '@angular/material/dialog';
import { AppComponent } from './app.component';
import { DataTablesModule } from 'angular-datatables';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { AutocompleteLibModule } from 'angular-ng-autocomplete';
/////////////////////***********************Angular Material *****************////////////////////////
import { MatSelectModule } from '@angular/material'
import { MatAutocompleteModule } from '@angular/material'


import { Ng2SearchPipeModule } from 'ng2-search-filter'
import { DropdownModule } from 'primeng/dropdown';
import { NgSelectModule } from '@ng-select/ng-select';

/////////////////////////*********************Services**************//////////////////////////////////////
import { TransactionsService } from './services/StoreTransaction/transactions.service';
import { SharingDataService } from './services/SharingData/sharing-data.service';

//////////////////////////******************Components**************/////////////////////////////////////
import { NavMenuComponent } from './Components/nav-menu/nav-menu.component';
import { AllTransactionsComponent } from './Components/Transactions/StoreTransaction/all-transactions/all-transactions.component';
import { CreateTransactionComponent } from './Components/Transactions/StoreTransaction/create-transaction/create-transaction.component';
import { TransactionsListComponent } from './Components/Transactions/transactions-list/transactions-list.component';
import { TransactionSpecificComponent } from './Components/Transactions/StoreTransaction/transaction-specific/transaction-specific.component';
import { DialogContentDatatabelComponent } from './Components/Transactions/StoreTransaction/dialog-content-datatabel/dialog-content-datatabel.component';
import { DialogEditProductComponent } from './Components/Transactions/StoreTransaction/dialog-edit-product/dialog-edit-product.component';
import { DialogEditStoreTransDeatailsComponent } from './Components/Transactions/StoreTransaction/dialog-edit-store-trans-deatails/dialog-edit-store-trans-deatails.component';
import { DialogForCategoryComponent } from './Components/Transactions/StoreTransaction/dialog-for-category/dialog-for-category.component';

/////////////////////////*********************Localization************/////////////////////////////////
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';


import { UniteListComponent } from './Components/BasicData/Unites/unite-list/unite-list.component';
import { UniteOperationComponent } from './Components/BasicData/Unites/unite-operation/unite-operation.component';
import { CurrencyListComponent } from './Components/BasicData/Currency/currency-list/currency-list.component'
import { CurrencyOperationComponent } from './Components/BasicData/Currency/currency-operation/currency-operation.component';



export function createTranslateLoader(http: HttpClient)
{
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    AllTransactionsComponent,
    CreateTransactionComponent,
    TransactionsListComponent,
    TransactionSpecificComponent,
    DialogContentDatatabelComponent,
    DialogEditProductComponent,
    DialogEditStoreTransDeatailsComponent,
    DialogForCategoryComponent,
    UniteListComponent,
    UniteOperationComponent,
    CurrencyListComponent,
    CurrencyOperationComponent
  ],
  entryComponents: [DialogContentDatatabelComponent, DialogEditProductComponent, DialogEditStoreTransDeatailsComponent, DialogForCategoryComponent],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    DataTablesModule,
    DateTimePickerModule,
    MatDialogModule,
    MatInputModule,
    MatFormFieldModule,
    AutocompleteLibModule,
    MatSelectModule,
    MatAutocompleteModule,
    ReactiveFormsModule,
    Ng2SearchPipeModule,
    DropdownModule,
    NgSelectModule,
   
   
    RouterModule.forRoot([
      { path: '', component: TransactionsListComponent, pathMatch: 'full' },
      { path: 'all-transactions/:id', component: AllTransactionsComponent },
      { path: 'create-transaction', component: CreateTransactionComponent },
      { path: 'transaction-list', component: TransactionsListComponent },
      { path: 'transaction-specific/:id/:userId', component: TransactionSpecificComponent },

      {
        path: 'basicdata',
        children:
          [
            {
              path: 'currency',
              children:
                [
                  {
                    path: '',
                    component: CurrencyListComponent
                    
                  },
                  {
                    path: 'CurrencyOperation',
                    component: CurrencyOperationComponent

                  },
                ],
            },
            {
              path: 'unite',
              children:
                [
                  {
                    path: '',
                    component: UniteListComponent
                  },
                  {
                    path: 'UniteOperation',
                    component: UniteOperationComponent
                  },
                ],
            },
          ],
      },


    ]),
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: createTranslateLoader,
        deps: [HttpClient],
      },
      defaultLanguage:'ar',
    } ),
    BrowserAnimationsModule
  ],
  providers: [TransactionsService, SharingDataService],
  bootstrap: [AppComponent],
  schemas:
    [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
