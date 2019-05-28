// ALLOWOVERWRITE-26883550D02AD50239B3C5241A4DEA72


    export interface ICustomerView {
      active: boolean;    	
      customerExteranlRef: string;    	
      customerId: number;    	
      emalAddress: string;    	
      isCompany: boolean;    	
      name: string;    	
      phoneNumber: string;    	
      taxNo: string;    	

					    entityEntityId : number;   
    }
    
    export class CustomerView implements ICustomerView {
      active: boolean;    	
      customerExteranlRef: string;    	
      customerId: number;    	
      emalAddress: string;    	
      isCompany: boolean;    	
      name: string;    	
      phoneNumber: string;    	
      taxNo: string;    	

					    entityEntityId : number ;   


	  constructor() {
	  }
    }

