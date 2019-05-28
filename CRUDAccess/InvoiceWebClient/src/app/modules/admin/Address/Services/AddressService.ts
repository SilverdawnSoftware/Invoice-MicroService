// ALLOWOVERWRITE-808C83DF9C9EF8E89D04C773741B5D31




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {AddressView} from '../Models/AddressView';


@Injectable()
export class AddressService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<AddressView[]> {
    return this.http.get<AddressView[]>(this.baseURL + `/api/Address/All`)
      .pipe(
        catchError(this.handleError('getAddresss', [])));
  }  
	 	
 	get(id: number | string): Observable<AddressView> {
		return this.http.get<AddressView>(this.baseURL + `/api/Address/${id}`)
      		.pipe(
         		catchError(this.handleError<AddressView>(`getaddressId=${id}`)
         	)
   		);
 	}
 	 
	add(address: AddressView): Observable<AddressView > {
    	return this.http.post<AddressView>(this.baseURL + '/api/Address', address)
      		.pipe(
    			catchError(this.handleError<AddressView>('addAddress')
    		)	
    	);
  	}
 	 
 	 
 	update(addressId: number,  address: AddressView): Observable<AddressView > {
    	return this.http.put<AddressView >(this.baseURL + `/api/Entity/${addressId}`, address)
      		.pipe(
        		catchError(this.handleError<AddressView>('addAddress')
        	)
      	);
  	}
 	 
 	 
 	remove(addressId: number): Observable<AddressView > {
     	return this.http.delete<AddressView >(this.baseURL + `/api/Address/${addressId}`)
        	.pipe(
          		catchError(this.handleError<AddressView>('addAddress')
          	)
        );
  	} 	  	 
  		  		
		    	
		    	getAddresssByCustomer(customerId: number): Observable<AddressView[]> {
    return this.http.get<AddressView[]>(this.baseURL + `/api/Customer/${customerId}/Addresss`)
     .pipe(
        catchError(this.handleError('getAddresssByCustomer', [])));
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

    
  

	




