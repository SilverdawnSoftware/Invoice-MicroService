// ALLOWOVERWRITE-FEA280A32766225D92769893344F1578

import {Component, OnInit} from '@angular/core';
import {InvoiceService} from '../Services/InvoiceService';
import {InvoiceView,IInvoiceView} from '../models/InvoiceView';


@Component({

  templateUrl: `./InvoiceIndex.html`,
  providers: [
    InvoiceService  ]
})

export class InvoiceIndex implements OnInit{

  rows: any;

  constructor(private invoiceService: InvoiceService) {

  }


  ngOnInit() {

    this.invoiceService.getAll().subscribe(value => this.rows=value);
  }

  delete(invoiceId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.invoiceService.remove(invoiceId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].invoiceId === invoiceId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




