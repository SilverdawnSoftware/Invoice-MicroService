// ALLOWOVERWRITE-AE746BCE1BE43F67A985E79572EA8D8B

import {Component, OnInit} from '@angular/core';
import {AddressService} from '../Services/AddressService';
import {AddressView,IAddressView} from '../models/AddressView';


@Component({

  templateUrl: `./AddressIndex.html`,
  providers: [
    AddressService  ]
})

export class AddressIndex implements OnInit{

  rows: any;

  constructor(private addressService: AddressService) {

  }


  ngOnInit() {

    this.addressService.getAll().subscribe(value => this.rows=value);
  }

  delete(addressId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.addressService.remove(addressId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].addressId === addressId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




