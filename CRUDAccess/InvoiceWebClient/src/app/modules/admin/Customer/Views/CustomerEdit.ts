// ALLOWOVERWRITE-2C5AF8C32971B6BE40C60C0BE7153299

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {ICustomerView} from "../Models/CustomerView";
import {CustomerView} from "../Models/CustomerView";
import {CustomerService} from "../Services/CustomerService";

// Add service imports
    		
//Add Target Assoications    

   					
import {AddressService} from "../../Address/Services/AddressService"	
import {InvoiceService} from "../../Invoice/Services/InvoiceService"	
    		
// Add view Models Imports


// Add  Target Assoications view Models
 import { IAddressView } from "../../Address/Models/AddressView";
 import { IInvoiceView } from "../../Invoice/Models/InvoiceView";
 

@Component({

  templateUrl: `./CustomerEdit.html`,
  providers: [
    CustomerService 

,AddressService
,InvoiceService
]
})





        export class CustomerEdit implements OnInit {
  customerForm: FormGroup;
  customerView: ICustomerView;
  customerId: number=0;
  entityEntityId : number;   
    addressrows: any; 
  invoicerows: any; 
  
  constructor(private formBuilder: FormBuilder, private customerService: CustomerService, private route: ActivatedRoute, private router: Router, private location: Location
,private addressService: AddressService
,private invoiceService: InvoiceService
  ) {

    this.customerView=new CustomerView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.customerForm = this.formBuilder.group({
	    				active: "", 
	    				customerExteranlRef: "", 
	    				emalAddress: "", 
	    				isCompany: "", 
	    				name: "", 
	    				phoneNumber: "", 
	    				taxNo: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.customerId =params['id'];
          if (this.customerId>0) {
        	this.customerService.get(+params['id']).subscribe(customer => this.displayCustomer(customer));
  			 this.addressService.getAddresssByCustomer(this.customerId).subscribe(value => this.addressrows=value); 
  			 this.invoiceService.getInvoicesByCustomer(this.customerId).subscribe(value => this.invoicerows=value); 
      		}
      	});
      	
    
    	 this.route.queryParams.subscribe( params=>{
         this.entityEntityId=params['entityEntityId'];
       });
    
      	
      	
		
    }

  update() {
          const customerModel = this.customerForm.value;
          if (this.customerId>0)
          {
            this.customerService.update(this.customerId,customerModel).subscribe(value => this.displayCustomer(value));
          }
          else
          {
      		  customerModel.entityEntityId=this.entityEntityId;
              this.customerService.add(customerModel).subscribe(value => this.router.navigateByUrl("/admin/customer/edit/"+value.customerId));
          }
      }

    displayCustomer(customerView: CustomerView) {
    this.customerForm.reset(customerView);  	
	this.customerView=customerView;	    
    }
    
    
    deleteAddress(addressId: number)
  	{
	    if (confirm('Are you sure you want to delete this?'))
	    {
	      this.addressService.remove(addressId).subscribe();
	
	      for(var i = this.addressrows.length - 1; i >= 0; i--) {
	        if(this.addressrows[i].addressId === addressId) {
	          this.addressrows.splice(i, 1);
	          break;
	        }
	      }
	    }
  	}
  	
    
    deleteInvoice(invoiceId: number)
  	{
	    if (confirm('Are you sure you want to delete this?'))
	    {
	      this.invoiceService.remove(invoiceId).subscribe();
	
	      for(var i = this.invoicerows.length - 1; i >= 0; i--) {
	        if(this.invoicerows[i].invoiceId === invoiceId) {
	          this.invoicerows.splice(i, 1);
	          break;
	        }
	      }
	    }
  	}
  	
 }  
 
 
