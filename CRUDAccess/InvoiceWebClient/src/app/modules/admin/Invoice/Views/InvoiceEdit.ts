// ALLOWOVERWRITE-44CA76BF7FA686F94293340E9ECEEA03

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IInvoiceView} from "../Models/InvoiceView";
import {InvoiceView} from "../Models/InvoiceView";
import {InvoiceService} from "../Services/InvoiceService";

// Add service imports
import {AddressService} from "../../Address/Services/AddressService"	
    		
//Add Target Assoications    

   					
import {InvoiceLineService} from "../../InvoiceLine/Services/InvoiceLineService"	
    		
// Add view Models Imports

 import { IAddressView } from "../../Address/Models/AddressView";

// Add  Target Assoications view Models
 import { IInvoiceLineView } from "../../InvoiceLine/Models/InvoiceLineView";
 

@Component({

  templateUrl: `./InvoiceEdit.html`,
  providers: [
    InvoiceService 

,InvoiceLineService
]
})





        export class InvoiceEdit implements OnInit {
  invoiceForm: FormGroup;
  invoiceView: IInvoiceView;
  invoiceId: number=0;
  customerCustomerId : number;   
    invoiceLinerows: any; 
  
  constructor(private formBuilder: FormBuilder, private invoiceService: InvoiceService, private route: ActivatedRoute, private router: Router, private location: Location
,private invoiceLineService: InvoiceLineService
  ) {

    this.invoiceView=new InvoiceView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.invoiceForm = this.formBuilder.group({
	    				createdDate: new Date().toISOString().substring(0, 10), 
	    				dueDate: new Date().toISOString().substring(0, 10), 
	    				emailTo: "", 
	    				grandTotal: 0, 
	    				invoiceEmailed: "", 
	    				invoiceNo: 0, 
	    				orderedBy: "", 
	    				paidAmount: 0, 
	    				paidDate: new Date().toISOString().substring(0, 10), 
	    				paidTax: 0, 
	    				paymentDetails: "", 
	    				purchaseOrderRef: "", 
	    				shippingAddress: "", 
	    				subTotal: 0, 
	    				tax: 0, 
	    				termsAndConditions : "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.invoiceId =params['id'];
          if (this.invoiceId>0) {
        	this.invoiceService.get(+params['id']).subscribe(invoice => this.displayInvoice(invoice));
  			 this.invoiceLineService.getInvoiceLinesByInvoice(this.invoiceId).subscribe(value => this.invoiceLinerows=value); 
      		}
      	});
      	
    
    	 this.route.queryParams.subscribe( params=>{
         this.customerCustomerId=params['customerCustomerId'];
       });
    
      	
      	
		
    }

  update() {
          const invoiceModel = this.invoiceForm.value;
          if (this.invoiceId>0)
          {
            this.invoiceService.update(this.invoiceId,invoiceModel).subscribe(value => this.displayInvoice(value));
          }
          else
          {
      		  invoiceModel.customerCustomerId=this.customerCustomerId;
              this.invoiceService.add(invoiceModel).subscribe(value => this.router.navigateByUrl("/admin/invoice/edit/"+value.invoiceId));
          }
      }

    displayInvoice(invoiceView: InvoiceView) {
	 	invoiceView.createdDate=new Date(invoiceView.createdDate).toISOString().substring(0, 10);
	 	invoiceView.dueDate=new Date(invoiceView.dueDate).toISOString().substring(0, 10);
	 	invoiceView.paidDate=new Date(invoiceView.paidDate).toISOString().substring(0, 10);
    this.invoiceForm.reset(invoiceView);  	
	this.invoiceView=invoiceView;	    
    }
    
    
    deleteInvoiceLine(invoiceLineId: number)
  	{
	    if (confirm('Are you sure you want to delete this?'))
	    {
	      this.invoiceLineService.remove(invoiceLineId).subscribe();
	
	      for(var i = this.invoiceLinerows.length - 1; i >= 0; i--) {
	        if(this.invoiceLinerows[i].invoiceLineId === invoiceLineId) {
	          this.invoiceLinerows.splice(i, 1);
	          break;
	        }
	      }
	    }
  	}
  	
 }  
 
 
