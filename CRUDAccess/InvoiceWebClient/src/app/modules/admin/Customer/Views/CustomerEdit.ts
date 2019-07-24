// ALLOWOVERWRITE-50FDADEC47A55277A00153604A1EFAA3

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {ICustomerView} from "../Models/CustomerView";
import {CustomerView} from "../Models/CustomerView";
import {CustomerService} from "../Services/CustomerService";

// Add service imports
import {AddressService} from "../../Address/Services/AddressService"	
    		
//Add Target Assoications    

   					
import {InvoiceService} from "../../Invoice/Services/InvoiceService"	
    		
// Add view Models Imports

 import { IAddressView } from "../../Address/Models/AddressView";

// Add  Target Assoications view Models
 import { IInvoiceView } from "../../Invoice/Models/InvoiceView";
 

@Component({

  templateUrl: `./CustomerEdit.html`,
  providers: [
    CustomerService 

,InvoiceService
]
})





        export class CustomerEdit implements OnInit {
  customerForm: FormGroup;
  customerView: ICustomerView;
  customerId: number=0;
  entityEntityId : number;   
    invoicerows: any; 
  
  constructor(private formBuilder: FormBuilder, private customerService: CustomerService, private route: ActivatedRoute, private router: Router, private location: Location
,private invoiceService: InvoiceService
  ) {

    this.customerView=new CustomerView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.customerForm = this.formBuilder.group({
	    				active: "", 
	    				customerExteranlRef: "", 
	    				emailAddress: "", 
	    				isCompany: "", 
	    				name: "", 
	    				phoneNumber: "", 
	    				taxNo: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.customerId =params['id'];
          if (this.customerId>0) {
        	this.customerService.get(+params['id']).subscribe(customer => this.displayCustomer(customer));
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
 
 
