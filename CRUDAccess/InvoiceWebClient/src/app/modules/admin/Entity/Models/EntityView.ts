// ALLOWOVERWRITE-2EF0C81866EA858E3CE5B897432E10BA


    export interface IEntityView {
      addressAddressId: number;
      addressPostZipCode: string;		    			
      entityExternalRef: string;    	
      entityId: number;    	
      logoURL: string;    	
      name: string;    	

    }
    
    export class EntityView implements IEntityView {
      addressAddressId: number;
      addressPostZipCode: string;		    			
      entityExternalRef: string;    	
      entityId: number;    	
      logoURL: string;    	
      name: string;    	



	  constructor() {
	  }
    }

