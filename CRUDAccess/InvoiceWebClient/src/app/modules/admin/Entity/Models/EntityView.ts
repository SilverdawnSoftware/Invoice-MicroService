// ALLOWOVERWRITE-1B7B215D98446F3648DAA8A4F8101AAA


    export interface IEntityView {
      addressPostZipCode: string;		    			
      entityExternalRef: string;    	
      entityId: number;    	
      logoURL: string;    	
      name: string;    	
      sMTPEmailDisplayName: string;    	
      sMTPEmailFromAddress: string;    	
      sMTPHost: string;    	
      sMTPPassword: string;    	
      sMTPUserName: string;    	

    }
    
    export class EntityView implements IEntityView {
      addressPostZipCode: string;		    			
      entityExternalRef: string;    	
      entityId: number;    	
      logoURL: string;    	
      name: string;    	
      sMTPEmailDisplayName: string;    	
      sMTPEmailFromAddress: string;    	
      sMTPHost: string;    	
      sMTPPassword: string;    	
      sMTPUserName: string;    	



	  constructor() {
	  }
    }

