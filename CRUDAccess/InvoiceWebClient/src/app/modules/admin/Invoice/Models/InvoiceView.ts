// ALLOWOVERWRITE-2C7E90461D36438B2A509DAC417D945B


    export interface IInvoiceView {
      billngAddressAddressId: number;
      billngAddressPostZipCode: string;		    			
      createdDate: string;    	
      dueDate: string;    	
      emailTo: string;    	
      grandTotal: number;    	
      invoiceEmailed: boolean;    	
      invoiceId: number;    	
      invoiceNo: number;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddress: string;    	
      subTotal: number;    	
      tax: number;    	
      termsAndConditions : string;    	

					    customerCustomerId : number;   
					    customerName : string;   
    }
    
    export class InvoiceView implements IInvoiceView {
      billngAddressAddressId: number;
      billngAddressPostZipCode: string;		    			
      createdDate: string;    	
      dueDate: string;    	
      emailTo: string;    	
      grandTotal: number;    	
      invoiceEmailed: boolean;    	
      invoiceId: number;    	
      invoiceNo: number;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddress: string;    	
      subTotal: number;    	
      tax: number;    	
      termsAndConditions : string;    	

					    customerCustomerId : number ;   
					    customerName : string;   


	  constructor() {
	  }
    }
