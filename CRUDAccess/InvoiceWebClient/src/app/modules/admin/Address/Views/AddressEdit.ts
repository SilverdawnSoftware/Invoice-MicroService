// ALLOWOVERWRITE-DC3D45D3A9729A5A34D8E4284CD65E6A

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IAddressView} from "../Models/AddressView";
import {AddressView} from "../Models/AddressView";
import {AddressService} from "../Services/AddressService";

// Add service imports
    		
//Add Target Assoications    

   					
    		
// Add view Models Imports


// Add  Target Assoications view Models
 

@Component({

  templateUrl: `./AddressEdit.html`,
  providers: [
    AddressService 

]
})





        export class AddressEdit implements OnInit {
  addressForm: FormGroup;
  addressView: IAddressView;
  addressId: number=0;
    
  constructor(private formBuilder: FormBuilder, private addressService: AddressService, private route: ActivatedRoute, private router: Router, private location: Location
  ) {

    this.addressView=new AddressView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.addressForm = this.formBuilder.group({
	    				addresLine2: "", 
	    				addressExternalRef: "", 
	    				addressLine1: "", 
	    				addressLine3: "", 
	    				city: "", 
	    				country: "", 
	    				postZipCode: "", 
	    				stateCounty: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this. =params['id'];
          if (this.>0) {
        	this.addressService.get(+params['id']).subscribe(address => this.displayAddress(address));
      		}
      	});
      	
      	
      	
		
    }

  update() {
          const addressModel = this.addressForm.value;
          if (this.>0)
          {
            this.addressService.update(this.,addressModel).subscribe(value => this.displayAddress(value));
          }
          else
          {
              this.addressService.add(addressModel).subscribe(value => this.router.navigateByUrl("/admin/address/edit/"+value.));
          }
      }

    displayAddress(addressView: AddressView) {
    this.addressForm.reset(addressView);  	
	this.addressView=addressView;	    
    }
    
 }  
 
 
