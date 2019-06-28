// ALLOWOVERWRITE-1B3499D92EA623E424DD1A34C0C729D7




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

    
  

	




