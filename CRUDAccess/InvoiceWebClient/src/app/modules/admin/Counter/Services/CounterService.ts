// ALLOWOVERWRITE-C19E5D3F5C84A9F313E0D9FBAB561B58-3AE626EC0F1A261651B5B8C45C91D44F




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {CounterView} from '../Models/CounterView';


@Injectable()
export class CounterService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<CounterView[]> {
    return this.http.get<CounterView[]>(this.baseURL + `/api/Counter/All`)
      .pipe(
        catchError(this.handleError('getCounters', [])));
  }  
	 	
 	get(id: number | string): Observable<CounterView> {
		return this.http.get<CounterView>(this.baseURL + `/api/Counter/${id}`)
      		.pipe(
         		catchError(this.handleError<CounterView>(`getname=${id}`)
         	)
   		);
 	}
 	 
	add(counter: CounterView): Observable<CounterView > {
    	return this.http.post<CounterView>(this.baseURL + '/api/Counter', counter)
      		.pipe(
    			catchError(this.handleError<CounterView>('addCounter')
    		)	
    	);
  	}
 	 
 	 
 	update(name: number,  counter: CounterView): Observable<CounterView > {
    	return this.http.put<CounterView >(this.baseURL + `/api/Entity/${name}`, counter)
      		.pipe(
        		catchError(this.handleError<CounterView>('addCounter')
        	)
      	);
  	}
 	 
 	 
 	remove(name: number): Observable<CounterView > {
     	return this.http.delete<CounterView >(this.baseURL + `/api/Counter/${name}`)
        	.pipe(
          		catchError(this.handleError<CounterView>('addCounter')
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

    
  

	




