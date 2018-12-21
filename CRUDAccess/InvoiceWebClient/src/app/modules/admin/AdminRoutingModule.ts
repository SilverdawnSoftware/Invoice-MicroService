// ALLOWOVERWRITE-4B15C189C404462CCBBCB0A5D87CCFDD


import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {InvoiceIndex} from './Invoice/Views/InvoiceIndex'
import {InvoiceEdit} from './Invoice/Views/InvoiceEdit'
import {CustomerIndex} from './Customer/Views/CustomerIndex'
import {CustomerEdit} from './Customer/Views/CustomerEdit'
import {AddressIndex} from './Address/Views/AddressIndex'
import {AddressEdit} from './Address/Views/AddressEdit'
import {InvoiceLineIndex} from './InvoiceLine/Views/InvoiceLineIndex'
import {InvoiceLineEdit} from './InvoiceLine/Views/InvoiceLineEdit'
import {EntityIndex} from './Entity/Views/EntityIndex'
import {EntityEdit} from './Entity/Views/EntityEdit'

const appRoutes: Routes = [
  
  {
    path: 'admin/invoice/',
    component: InvoiceIndex,

  },
  {
    path: 'admin/invoice/edit/:id',
    component: InvoiceEdit
  },
  {
    path: 'admin/invoice/add',
    component: InvoiceEdit
  },
  
  
  {
    path: 'admin/customer/',
    component: CustomerIndex,

  },
  {
    path: 'admin/customer/edit/:id',
    component: CustomerEdit
  },
  {
    path: 'admin/customer/add',
    component: CustomerEdit
  },
  
  
  {
    path: 'admin/address/',
    component: AddressIndex,

  },
  {
    path: 'admin/address/edit/:id',
    component: AddressEdit
  },
  {
    path: 'admin/address/add',
    component: AddressEdit
  },
  
  
  {
    path: 'admin/invoiceLine/',
    component: InvoiceLineIndex,

  },
  {
    path: 'admin/invoiceLine/edit/:id',
    component: InvoiceLineEdit
  },
  {
    path: 'admin/invoiceLine/add',
    component: InvoiceLineEdit
  },
  
  
  {
    path: 'admin/entity/',
    component: EntityIndex,

  },
  {
    path: 'admin/entity/edit/:id',
    component: EntityEdit
  },
  {
    path: 'admin/entity/add',
    component: EntityEdit
  },
  
  { path: '',   redirectTo: '/admin/user', pathMatch: 'full' },
  { path: '**', component: EntityIndex }
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes )
  ],
  exports: [
    RouterModule
  ],
  providers: [
  ]
})
export class AdminRoutingModule { }


