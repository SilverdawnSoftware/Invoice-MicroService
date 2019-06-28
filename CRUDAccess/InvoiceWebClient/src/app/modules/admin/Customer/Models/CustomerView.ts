// ALLOWOVERWRITE-4B4141E844815DF26FE4A9A113495D83-0C45F0ADC5CF5D02D47C8C5C878074FA


    export interface ICustomerView {
      active: boolean;    	
      addressPostZipCode: string;		    			
      customerExteranlRef: string;    	
      customerId: number;    	
      emailAddress: string;    	
      isCompany: boolean;    	
      name: string;    	
      phoneNumber: string;    	
      taxNo: string;    	

					    entityEntityId : number;   
    }
    
    export class CustomerView implements ICustomerView {
      active: boolean;    	
      addressPostZipCode: string;		    			
      customerExteranlRef: string;    	
      customerId: number;    	
      emailAddress: string;    	
      isCompany: boolean;    	
      name: string;    	
      phoneNumber: string;    	
      taxNo: string;    	

					    entityEntityId : number ;   


	  constructor() {
	  }
    }

