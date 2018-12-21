// ALLOWOVERWRITE-D4A47726E9D5DBE72C505D1550B22F16




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {InvoiceView} from '../Models/InvoiceView';


@Injectable()
export class InvoiceService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<InvoiceView[]> {
    return this.http.get<InvoiceView[]>(this.baseURL + `/api/Invoice/All`)
      .pipe(
        catchError(this.handleError('getInvoices', [])));
  }  
	 	
 	get(id: number | string): Observable<InvoiceView> {
		return this.http.get<InvoiceView>(this.baseURL + `/api/Invoice/${id}`)
      		.pipe(
         		catchError(this.handleError<InvoiceView>(`getinvoiceId=${id}`)
         	)
   		);
 	}
 	 
	add(invoice: InvoiceView): Observable<InvoiceView > {
    	return this.http.post<InvoiceView>(this.baseURL + '/api/Invoice', invoice)
      		.pipe(
    			catchError(this.handleError<InvoiceView>('addInvoice')
    		)	
    	);
  	}
 	 
 	 
 	update(invoiceId: number,  invoice: InvoiceView): Observable<InvoiceView > {
    	return this.http.put<InvoiceView >(this.baseURL + `/api/Entity/${invoiceId}`, invoice)
      		.pipe(
        		catchError(this.handleError<InvoiceView>('addInvoice')
        	)
      	);
  	}
 	 
 	 
 	remove(invoiceId: number): Observable<InvoiceView > {
     	return this.http.delete<InvoiceView >(this.baseURL + `/api/Invoice/${invoiceId}`)
        	.pipe(
          		catchError(this.handleError<InvoiceView>('addInvoice')
          	)
        );
  	} 	  	 
  		  		
		    	
		    	getInvoicesByCustomer(customerId: number): Observable<InvoiceView[]> {
    return this.http.get<InvoiceView[]>(this.baseURL + `/api/Customer/${customerId}/Invoices`)
     .pipe(
        catchError(this.handleError('getInvoicesByCustomer', [])));
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

    
  

	



