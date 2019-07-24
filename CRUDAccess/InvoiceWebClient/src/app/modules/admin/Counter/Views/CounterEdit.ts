// ALLOWOVERWRITE-B5A15ED65807448DEC7143AB38C0B549

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {ICounterView} from "../Models/CounterView";
import {CounterView} from "../Models/CounterView";
import {CounterService} from "../Services/CounterService";

// Add service imports
    		
//Add Target Assoications    

   					
    		
// Add view Models Imports


// Add  Target Assoications view Models
 

@Component({

  templateUrl: `./CounterEdit.html`,
  providers: [
    CounterService 

]
})





        export class CounterEdit implements OnInit {
  counterForm: FormGroup;
  counterView: ICounterView;
  counterId: number=0;
    
  constructor(private formBuilder: FormBuilder, private counterService: CounterService, private route: ActivatedRoute, private router: Router, private location: Location
  ) {

    this.counterView=new CounterView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.counterForm = this.formBuilder.group({
	    				value: 0, 
      
    });
         
       this.route.params.subscribe(params => {
        this.name =params['id'];
          if (this.name>0) {
        	this.counterService.get(+params['id']).subscribe(counter => this.displayCounter(counter));
      		}
      	});
      	
      	
      	
		
    }

  update() {
          const counterModel = this.counterForm.value;
          if (this.name>0)
          {
            this.counterService.update(this.name,counterModel).subscribe(value => this.displayCounter(value));
          }
          else
          {
              this.counterService.add(counterModel).subscribe(value => this.router.navigateByUrl("/admin/counter/edit/"+value.name));
          }
      }

    displayCounter(counterView: CounterView) {
    this.counterForm.reset(counterView);  	
	this.counterView=counterView;	    
    }
    
 }  
 
 
