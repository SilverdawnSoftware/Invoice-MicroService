// ALLOWOVERWRITE-1C596578A2BB9744885C1CA5C4C7EE3B

import {Component, OnInit} from '@angular/core';
import {CustomerService} from '../Services/CustomerService';
import {CustomerView,ICustomerView} from '../models/CustomerView';


@Component({

  templateUrl: `./CustomerIndex.html`,
  providers: [
    CustomerService  ]
})

export class CustomerIndex implements OnInit{

  rows: any;

  constructor(private customerService: CustomerService) {

  }


  ngOnInit() {

    this.customerService.getAll().subscribe(value => this.rows=value);
  }

  delete(customerId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.customerService.remove(customerId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].customerId === customerId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}



