// ALLOWOVERWRITE-DDEBB8EE8454AC442E81E67DE49083DC-5A4F8EEFC6284A264447385C9578633E

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HttpModule }    from '@angular/http';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { AdminRoutingModule } from "./modules/admin/AdminRoutingModule";
import {AppShell} from "./modules/shell/appshell";
import {CdkTableModule} from '@angular/cdk/table';
import { HttpClientModule } from '@angular/common/http';

import { MatAutocompleteModule,
  MatButtonModule,
  MatButtonToggleModule,
  MatCardModule,
  MatCheckboxModule,
  MatChipsModule,
  MatDatepickerModule,
  MatDialogModule,
  MatExpansionModule,
  MatGridListModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatNativeDateModule,
  MatPaginatorModule,
  MatProgressBarModule,
  MatProgressSpinnerModule,
  MatRadioModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSliderModule,
  MatSlideToggleModule,
  MatSnackBarModule,
  MatSortModule,
  MatTableModule,
  MatTabsModule,
  MatToolbarModule,
  MatTooltipModule,
  MatStepperModule,} from '@angular/material';




import {InvoiceIndex} from './modules/admin/Invoice/Views/InvoiceIndex';
import {InvoiceEdit} from './modules/admin/Invoice/Views/InvoiceEdit';


import {CustomerIndex} from './modules/admin/Customer/Views/CustomerIndex';
import {CustomerEdit} from './modules/admin/Customer/Views/CustomerEdit';


import {AddressIndex} from './modules/admin/Address/Views/AddressIndex';
import {AddressEdit} from './modules/admin/Address/Views/AddressEdit';


import {InvoiceLineIndex} from './modules/admin/InvoiceLine/Views/InvoiceLineIndex';
import {InvoiceLineEdit} from './modules/admin/InvoiceLine/Views/InvoiceLineEdit';


import {EntityIndex} from './modules/admin/Entity/Views/EntityIndex';
import {EntityEdit} from './modules/admin/Entity/Views/EntityEdit';


import {CounterIndex} from './modules/admin/Counter/Views/CounterIndex';
import {CounterEdit} from './modules/admin/Counter/Views/CounterEdit';


@NgModule({
  exports: [
    CdkTableModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatStepperModule,
    MatDatepickerModule,
    MatDialogModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
  ]
})
export class AppMaterialModule {}



@NgModule({
  imports: [BrowserModule, ReactiveFormsModule, BrowserAnimationsModule, HttpModule, AdminRoutingModule, AppMaterialModule,NgxDatatableModule,FlexLayoutModule,HttpClientModule],
  declarations: [AppShell 
  ,InvoiceEdit,InvoiceIndex
  ,CustomerEdit,CustomerIndex
  ,AddressEdit,AddressIndex
  ,InvoiceLineEdit,InvoiceLineIndex
  ,EntityEdit,EntityIndex
  ,CounterEdit,CounterIndex
  
  
  ],
  bootstrap: [AppShell]
})
export class AppModule {}

//platformBrowserDynamic().bootstrapModule(AppModule);

