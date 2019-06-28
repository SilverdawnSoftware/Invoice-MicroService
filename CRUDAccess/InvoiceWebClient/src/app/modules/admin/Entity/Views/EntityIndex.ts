// ALLOWOVERWRITE-B9A2EFBF2780827A61C062975194CC61-82FC222F9C04E3368D9B631E794BF81D

import {Component, OnInit} from '@angular/core';
import {EntityService} from '../Services/EntityService';
import {EntityView,IEntityView} from '../models/EntityView';


@Component({

  templateUrl: `./EntityIndex.html`,
  providers: [
    EntityService  ]
})

export class EntityIndex implements OnInit{

  rows: any;

  constructor(private entityService: EntityService) {

  }


  ngOnInit() {

    this.entityService.getAll().subscribe(value => this.rows=value);
  }

  delete(entityId: number)
  {
    if (confirm('Are you sure you want to delete this?'))
    {
      this.entityService.remove(entityId).subscribe();

      for(var i = this.rows.length - 1; i >= 0; i--) {
        if(this.rows[i].entityId === entityId) {
          this.rows.splice(i, 1);
          break;
        }
      }
    }
  }


}




