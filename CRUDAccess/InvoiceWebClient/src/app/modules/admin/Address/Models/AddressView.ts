// ALLOWOVERWRITE-1816013EDA9AAEFE76EDEFBEADDFE59D


    export interface IAddressView {
      addresLine2: string;    	
      addressExternalRef: string;    	
      addressId: number;    	
      addressLine1: string;    	
      addressLine3: string;    	
      city: string;    	
      country: string;    	
      postZipCode: string;    	
      stateCounty: string;    	

					    customerCustomerId : number;   
					    customerName : string;   
    }
    
    export class AddressView implements IAddressView {
      addresLine2: string;    	
      addressExternalRef: string;    	
      addressId: number;    	
      addressLine1: string;    	
      addressLine3: string;    	
      city: string;    	
      country: string;    	
      postZipCode: string;    	
      stateCounty: string;    	

					    customerCustomerId : number ;   
					    customerName : string;   


	  constructor() {
	  }
    }

