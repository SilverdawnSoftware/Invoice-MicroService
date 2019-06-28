// ALLOWOVERWRITE-2093DE9DF1437993DB607471D4BE24AE-12911FA27E902DB41189E41DD7719A5A

import {Component, OnInit} from '@angular/core';
import {InvoiceLineService} from '../Services/InvoiceLineService';
import {InvoiceLineView,IInvoiceLineView} from '../models/InvoiceLineView';


@Component({

  templateUrl: `./InvoiceLineIndex.html`,
  providers: [
    InvoiceLineService  ]
})

export class InvoiceLineIndex implements OnInit{

  rows: any;

  constructor(private invoiceLineService: InvoiceLineService) {

  }


  ngOnInit() {

    this.invoiceLineService.getAll().subscribe(value => this.rows=value);
  }

  delete(invoiceLineId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.invoiceLineService.remove(invoiceLineId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].invoiceLineId === invoiceLineId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




