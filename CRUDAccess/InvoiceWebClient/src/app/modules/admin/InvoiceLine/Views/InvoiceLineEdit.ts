// ALLOWOVERWRITE-6D69B8DC2362E093FBBA2D08149E7941

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IInvoiceLineView} from "../Models/InvoiceLineView";
import {InvoiceLineView} from "../Models/InvoiceLineView";
import {InvoiceLineService} from "../Services/InvoiceLineService";

// Add service imports
    		
//Add Target Assoications    

   					
    		
// Add view Models Imports


// Add  Target Assoications view Models
 

@Component({

  templateUrl: `./InvoiceLineEdit.html`,
  providers: [
    InvoiceLineService 

]
})





        export class InvoiceLineEdit implements OnInit {
  invoiceLineForm: FormGroup;
  invoiceLineView: IInvoiceLineView;
  invoiceLineId: number=0;
  invoiceInvoiceId : number;   
    
  constructor(private formBuilder: FormBuilder, private invoiceLineService: InvoiceLineService, private route: ActivatedRoute, private router: Router, private location: Location
  ) {

    this.invoiceLineView=new InvoiceLineView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.invoiceLineForm = this.formBuilder.group({
	    				lineTotal: 0, 
	    				notes: "", 
	    				product: "", 
	    				productCode: "", 
	    				quantity: 0, 
	    				subTotal: 0, 
	    				taxExempt: "", 
	    				taxTotal: 0, 
	    				unitCost: 0, 
      
    });
         
       this.route.params.subscribe(params => {
        this.invoiceLineId =params['id'];
          if (this.invoiceLineId>0) {
        	this.invoiceLineService.get(+params['id']).subscribe(invoiceLine => this.displayInvoiceLine(invoiceLine));
      		}
      	});
      	
    
    	 this.route.queryParams.subscribe( params=>{
         this.invoiceInvoiceId=params['invoiceInvoiceId'];
       });
    
      	
      	
		
    }

  update() {
          const invoiceLineModel = this.invoiceLineForm.value;
          if (this.invoiceLineId>0)
          {
            this.invoiceLineService.update(this.invoiceLineId,invoiceLineModel).subscribe(value => this.displayInvoiceLine(value));
          }
          else
          {
      		  invoiceLineModel.invoiceInvoiceId=this.invoiceInvoiceId;
              this.invoiceLineService.add(invoiceLineModel).subscribe(value => this.router.navigateByUrl("/admin/invoiceLine/edit/"+value.invoiceLineId));
          }
      }

    displayInvoiceLine(invoiceLineView: InvoiceLineView) {
    this.invoiceLineForm.reset(invoiceLineView);  	
	this.invoiceLineView=invoiceLineView;	    
    }
    
 }  
 
 
