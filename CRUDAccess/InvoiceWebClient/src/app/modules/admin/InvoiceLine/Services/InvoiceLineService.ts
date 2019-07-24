// ALLOWOVERWRITE-D12E243685F82C29A7311A479569D56E




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {InvoiceLineView} from '../Models/InvoiceLineView';


@Injectable()
export class InvoiceLineService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<InvoiceLineView[]> {
    return this.http.get<InvoiceLineView[]>(this.baseURL + `/api/InvoiceLine/All`)
      .pipe(
        catchError(this.handleError('getInvoiceLines', [])));
  }  
	 	
 	get(id: number | string): Observable<InvoiceLineView> {
		return this.http.get<InvoiceLineView>(this.baseURL + `/api/InvoiceLine/${id}`)
      		.pipe(
         		catchError(this.handleError<InvoiceLineView>(`getinvoiceLineId=${id}`)
         	)
   		);
 	}
 	 
	add(invoiceLine: InvoiceLineView): Observable<InvoiceLineView > {
    	return this.http.post<InvoiceLineView>(this.baseURL + '/api/InvoiceLine', invoiceLine)
      		.pipe(
    			catchError(this.handleError<InvoiceLineView>('addInvoiceLine')
    		)	
    	);
  	}
 	 
 	 
 	update(invoiceLineId: number,  invoiceLine: InvoiceLineView): Observable<InvoiceLineView > {
    	return this.http.put<InvoiceLineView >(this.baseURL + `/api/Entity/${invoiceLineId}`, invoiceLine)
      		.pipe(
        		catchError(this.handleError<InvoiceLineView>('addInvoiceLine')
        	)
      	);
  	}
 	 
 	 
 	remove(invoiceLineId: number): Observable<InvoiceLineView > {
     	return this.http.delete<InvoiceLineView >(this.baseURL + `/api/InvoiceLine/${invoiceLineId}`)
        	.pipe(
          		catchError(this.handleError<InvoiceLineView>('addInvoiceLine')
          	)
        );
  	} 	  	 
  		  		
		    	
		    	getInvoiceLinesByInvoice(invoiceId: number): Observable<InvoiceLineView[]> {
    return this.http.get<InvoiceLineView[]>(this.baseURL + `/api/Invoice/${invoiceId}/InvoiceLines`)
     .pipe(
        catchError(this.handleError('getInvoiceLinesByInvoice', [])));
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

    
  

	




