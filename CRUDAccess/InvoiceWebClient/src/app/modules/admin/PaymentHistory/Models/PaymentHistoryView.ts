// ALLOWOVERWRITE-0085A2317930FAB9035BD26E1E682BC5


    export interface IPaymentHistoryView {
      amount: number;    	
      paymentDate: string;    	
      paymentHistoryId: number;    	
      reference: string;    	

					    invoiceInvoiceId : number;   
					    invoiceInvoiceNo : string;   
    }
    
    export class PaymentHistoryView implements IPaymentHistoryView {
      amount: number;    	
      paymentDate: string;    	
      paymentHistoryId: number;    	
      reference: string;    	

					    invoiceInvoiceId : number ;   
					    invoiceInvoiceNo : string;   


	  constructor() {
	  }
    }

