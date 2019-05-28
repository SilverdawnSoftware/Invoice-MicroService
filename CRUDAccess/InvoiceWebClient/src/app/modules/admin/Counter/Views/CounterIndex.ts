// ALLOWOVERWRITE-3134E5E394640DE85065EE6B48CCA2D8

import {Component, OnInit} from '@angular/core';
import {CounterService} from '../Services/CounterService';
import {CounterView,ICounterView} from '../models/CounterView';


@Component({

  templateUrl: `./CounterIndex.html`,
  providers: [
    CounterService  ]
})

export class CounterIndex implements OnInit{

  rows: any;

  constructor(private counterService: CounterService) {

  }


  ngOnInit() {

    this.counterService.getAll().subscribe(value => this.rows=value);
  }

  delete(name: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.counterService.remove(name).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].name === name) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




