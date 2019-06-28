// ALLOWOVERWRITE-921DC71751574DB655C5A1A8A40FB5AB-C974A90094959B6B6C0A1A337D264BD5


    export interface IInvoiceLineView {
      invoiceLineId: number;    	
      lineTotal: number;    	
      notes: string;    	
      product: string;    	
      productCode: string;    	
      quantity: number;    	
      subTotal: number;    	
      taxExempt: boolean;    	
      taxTotal: number;    	
      unitCost: number;    	

					    invoiceInvoiceId : number;   
					    invoiceInvoiceNo : string;   
    }
    
    export class InvoiceLineView implements IInvoiceLineView {
      invoiceLineId: number;    	
      lineTotal: number;    	
      notes: string;    	
      product: string;    	
      productCode: string;    	
      quantity: number;    	
      subTotal: number;    	
      taxExempt: boolean;    	
      taxTotal: number;    	
      unitCost: number;    	

					    invoiceInvoiceId : number ;   
					    invoiceInvoiceNo : string;   


	  constructor() {
	  }
    }

