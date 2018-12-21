// ALLOWOVERWRITE-EAB24B9977FC1795698F9A15E23EF4EF




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {CustomerView} from '../Models/CustomerView';


@Injectable()
export class CustomerService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<CustomerView[]> {
    return this.http.get<CustomerView[]>(this.baseURL + `/api/Customer/All`)
      .pipe(
        catchError(this.handleError('getCustomers', [])));
  }  
	 	
 	get(id: number | string): Observable<CustomerView> {
		return this.http.get<CustomerView>(this.baseURL + `/api/Customer/${id}`)
      		.pipe(
         		catchError(this.handleError<CustomerView>(`getcustomerId=${id}`)
         	)
   		);
 	}
 	 
	add(customer: CustomerView): Observable<CustomerView > {
    	return this.http.post<CustomerView>(this.baseURL + '/api/Customer', customer)
      		.pipe(
    			catchError(this.handleError<CustomerView>('addCustomer')
    		)	
    	);
  	}
 	 
 	 
 	update(customerId: number,  customer: CustomerView): Observable<CustomerView > {
    	return this.http.put<CustomerView >(this.baseURL + `/api/Entity/${customerId}`, customer)
      		.pipe(
        		catchError(this.handleError<CustomerView>('addCustomer')
        	)
      	);
  	}
 	 
 	 
 	remove(customerId: number): Observable<CustomerView > {
     	return this.http.delete<CustomerView >(this.baseURL + `/api/Customer/${customerId}`)
        	.pipe(
          		catchError(this.handleError<CustomerView>('addCustomer')
          	)
        );
  	} 	  	 
  		  		
		    	
		    	getCustomersByEntity(entityId: number): Observable<CustomerView[]> {
    return this.http.get<CustomerView[]>(this.baseURL + `/api/Entity/${entityId}/Customers`)
     .pipe(
        catchError(this.handleError('getCustomersByEntity', [])));
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

    
  

	



