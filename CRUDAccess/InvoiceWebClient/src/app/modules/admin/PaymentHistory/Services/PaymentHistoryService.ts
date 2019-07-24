// ALLOWOVERWRITE-7C57B068FD660251490046DE2247D227




import {Injectable} from '@angular/core';


import {Observable,of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {HttpClient} from '@angular/common/http';

import {PaymentHistoryView} from '../Models/PaymentHistoryView';


@Injectable()
export class PaymentHistoryService {
  constructor(private http: HttpClient) {
  }

  baseURL: string='http://localhost:44443';

 getAll(): Observable<PaymentHistoryView[]> {
    return this.http.get<PaymentHistoryView[]>(this.baseURL + `/api/PaymentHistory/All`)
      .pipe(
        catchError(this.handleError('getPaymentHistorys', [])));
  }  
	 	
 	get(id: number | string): Observable<PaymentHistoryView> {
		return this.http.get<PaymentHistoryView>(this.baseURL + `/api/PaymentHistory/${id}`)
      		.pipe(
         		catchError(this.handleError<PaymentHistoryView>(`getpaymentHistoryId=${id}`)
         	)
   		);
 	}
 	 
	add(paymentHistory: PaymentHistoryView): Observable<PaymentHistoryView > {
    	return this.http.post<PaymentHistoryView>(this.baseURL + '/api/PaymentHistory', paymentHistory)
      		.pipe(
    			catchError(this.handleError<PaymentHistoryView>('addPaymentHistory')
    		)	
    	);
  	}
 	 
 	 
 	update(paymentHistoryId: number,  paymentHistory: PaymentHistoryView): Observable<PaymentHistoryView > {
    	return this.http.put<PaymentHistoryView >(this.baseURL + `/api/Entity/${paymentHistoryId}`, paymentHistory)
      		.pipe(
        		catchError(this.handleError<PaymentHistoryView>('addPaymentHistory')
        	)
      	);
  	}
 	 
 	 
 	remove(paymentHistoryId: number): Observable<PaymentHistoryView > {
     	return this.http.delete<PaymentHistoryView >(this.baseURL + `/api/PaymentHistory/${paymentHistoryId}`)
        	.pipe(
          		catchError(this.handleError<PaymentHistoryView>('addPaymentHistory')
          	)
        );
  	} 	  	 
  		  		
		    	
		    	getPaymentHistorysByInvoice(invoiceId: number): Observable<PaymentHistoryView[]> {
    return this.http.get<PaymentHistoryView[]>(this.baseURL + `/api/Invoice/${invoiceId}/PaymentHistorys`)
     .pipe(
        catchError(this.handleError('getPaymentHistorysByInvoice', [])));
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

    
  

	




