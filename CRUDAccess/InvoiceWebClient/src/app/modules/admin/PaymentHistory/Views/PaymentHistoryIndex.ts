// ALLOWOVERWRITE-D00A8937C81320764A0A0AEBCE96951E

import {Component, OnInit} from '@angular/core';
import {PaymentHistoryService} from '../Services/PaymentHistoryService';
import {PaymentHistoryView,IPaymentHistoryView} from '../models/PaymentHistoryView';


@Component({

  templateUrl: `./PaymentHistoryIndex.html`,
  providers: [
    PaymentHistoryService  ]
})

export class PaymentHistoryIndex implements OnInit{

  rows: any;

  constructor(private paymentHistoryService: PaymentHistoryService) {

  }


  ngOnInit() {

    this.paymentHistoryService.getAll().subscribe(value => this.rows=value);
  }

  delete(paymentHistoryId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.paymentHistoryService.remove(paymentHistoryId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].paymentHistoryId === paymentHistoryId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




