// ALLOWOVERWRITE-918534830A75B49E0ED97DBE1620891B




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {EntityView} from '../Models/EntityView';


@Injectable()
export class EntityService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<EntityView[]> {
    return this.http.get<EntityView[]>(this.baseURL + `/api/Entity/All`)
      .pipe(
        catchError(this.handleError('getEntitys', [])));
  }  
	 	
 	get(id: number | string): Observable<EntityView> {
		return this.http.get<EntityView>(this.baseURL + `/api/Entity/${id}`)
      		.pipe(
         		catchError(this.handleError<EntityView>(`getentityId=${id}`)
         	)
   		);
 	}
 	 
	add(entity: EntityView): Observable<EntityView > {
    	return this.http.post<EntityView>(this.baseURL + '/api/Entity', entity)
      		.pipe(
    			catchError(this.handleError<EntityView>('addEntity')
    		)	
    	);
  	}
 	 
 	 
 	update(entityId: number,  entity: EntityView): Observable<EntityView > {
    	return this.http.put<EntityView >(this.baseURL + `/api/Entity/${entityId}`, entity)
      		.pipe(
        		catchError(this.handleError<EntityView>('addEntity')
        	)
      	);
  	}
 	 
 	 
 	remove(entityId: number): Observable<EntityView > {
     	return this.http.delete<EntityView >(this.baseURL + `/api/Entity/${entityId}`)
        	.pipe(
          		catchError(this.handleError<EntityView>('addEntity')
          	)
        );
  	} 	  	 
  		  		
   
   	
	/**
	* Handle Http operation that failed.
	* Let the app continue.
	* @param operation - name of the operation that failed
	* @param result - optional value to return as the observable result
	*/
	private handleError<T> (operation = 'operation', result?: T) {
		return (error: any): Observable<T> => {
		
		  // TODO: send the error to remote logging infrastructure
		  console.error(error); // log to console instead
		
		  // TODO: better job of transforming error for user consumption
		 // this.log(`${operation} failed: ${error.message}`);
		
		  // Let the app keep running by returning an empty result.
		  return of(result as T);
		};
	}
   

  }

    
  

	




