// ALLOWOVERWRITE-AB78110E4A9C6395F91819EADEDA9117

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IEntityView} from "../Models/EntityView";
import {EntityView} from "../Models/EntityView";
import {EntityService} from "../Services/EntityService";

// Add service imports
import {AddressService} from "../../Address/Services/AddressService"	
    		
//Add Target Assoications    

   					
import {CustomerService} from "../../Customer/Services/CustomerService"	
    		
// Add view Models Imports

 import { IAddressView } from "../../Address/Models/AddressView";

// Add  Target Assoications view Models
 import { ICustomerView } from "../../Customer/Models/CustomerView";
 

@Component({

  templateUrl: `./EntityEdit.html`,
  providers: [
    EntityService 

,CustomerService
]
})





        export class EntityEdit implements OnInit {
  entityForm: FormGroup;
  entityView: IEntityView;
  entityId: number=0;
    customerrows: any; 
  
  constructor(private formBuilder: FormBuilder, private entityService: EntityService, private route: ActivatedRoute, private router: Router, private location: Location
,private customerService: CustomerService
  ) {

    this.entityView=new EntityView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.entityForm = this.formBuilder.group({
	    				entityExternalRef: "", 
	    				logoURL: "", 
	    				name: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.entityId =params['id'];
          if (this.entityId>0) {
        	this.entityService.get(+params['id']).subscribe(entity => this.displayEntity(entity));
  			 this.customerService.getCustomersByEntity(this.entityId).subscribe(value => this.customerrows=value); 
      		}
      	});
      	
      	
      	
		
    }

  update() {
          const entityModel = this.entityForm.value;
          if (this.entityId>0)
          {
            this.entityService.update(this.entityId,entityModel).subscribe(value => this.displayEntity(value));
          }
          else
          {
              this.entityService.add(entityModel).subscribe(value => this.router.navigateByUrl("/admin/entity/edit/"+value.entityId));
          }
      }

    displayEntity(entityView: EntityView) {
    this.entityForm.reset(entityView);  	
	this.entityView=entityView;	    
    }
    
    
    deleteCustomer(customerId: number)
  	{
	    if (confirm('Are you sure you want to delete this?'))
	    {
	      this.customerService.remove(customerId).subscribe();
	
	      for(var i = this.customerrows.length - 1; i >= 0; i--) {
	        if(this.customerrows[i].customerId === customerId) {
	          this.customerrows.splice(i, 1);
	          break;
	        }
	      }
	    }
  	}
  	
 }  
 
 
