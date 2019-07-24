// ALLOWOVERWRITE-0CE4ACA6DE29C91885457DC6B2293E2C

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IPaymentHistoryView} from "../Models/PaymentHistoryView";
import {PaymentHistoryView} from "../Models/PaymentHistoryView";
import {PaymentHistoryService} from "../Services/PaymentHistoryService";

// Add service imports
    		
//Add Target Assoications    

   					
    		
// Add view Models Imports


// Add  Target Assoications view Models
 

@Component({

  templateUrl: `./PaymentHistoryEdit.html`,
  providers: [
    PaymentHistoryService 

]
})





        export class PaymentHistoryEdit implements OnInit {
  paymentHistoryForm: FormGroup;
  paymentHistoryView: IPaymentHistoryView;
  paymentHistoryId: number=0;
  invoiceInvoiceId : number;   
    
  constructor(private formBuilder: FormBuilder, private paymentHistoryService: PaymentHistoryService, private route: ActivatedRoute, private router: Router, private location: Location
  ) {

    this.paymentHistoryView=new PaymentHistoryView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.paymentHistoryForm = this.formBuilder.group({
	    				amount: 0, 
	    				paymentDate: new Date().toISOString().substring(0, 10), 
	    				reference: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.paymentHistoryId =params['id'];
          if (this.paymentHistoryId>0) {
        	this.paymentHistoryService.get(+params['id']).subscribe(paymentHistory => this.displayPaymentHistory(paymentHistory));
      		}
      	});
      	
    
    	 this.route.queryParams.subscribe( params=>{
         this.invoiceInvoiceId=params['invoiceInvoiceId'];
       });
    
      	
      	
		
    }

  update() {
          const paymentHistoryModel = this.paymentHistoryForm.value;
          if (this.paymentHistoryId>0)
          {
            this.paymentHistoryService.update(this.paymentHistoryId,paymentHistoryModel).subscribe(value => this.displayPaymentHistory(value));
          }
          else
          {
      		  paymentHistoryModel.invoiceInvoiceId=this.invoiceInvoiceId;
              this.paymentHistoryService.add(paymentHistoryModel).subscribe(value => this.router.navigateByUrl("/admin/paymentHistory/edit/"+value.paymentHistoryId));
          }
      }

    displayPaymentHistory(paymentHistoryView: PaymentHistoryView) {
	 	paymentHistoryView.paymentDate=new Date(paymentHistoryView.paymentDate).toISOString().substring(0, 10);
    this.paymentHistoryForm.reset(paymentHistoryView);  	
	this.paymentHistoryView=paymentHistoryView;	    
    }
    
 }  
 
 
