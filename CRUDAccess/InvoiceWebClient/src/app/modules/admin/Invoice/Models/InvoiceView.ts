// ALLOWOVERWRITE-CF4111E2F0FE20ABAFAEDD953962C0A5

					import {InvoiceStatus} from "../../Enums/InvoiceStatus"

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
      notes: string;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddressAddressId: number;
      shippingAddressPostZipCode: string;		    			
      status: InvoiceStatus;    	
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
      notes: string;    	
      orderedBy: string;    	
      paidAmount: number;    	
      paidDate: string;    	
      paidTax: number;    	
      paymentDetails: string;    	
      purchaseOrderRef: string;    	
      shippingAddressAddressId: number;
      shippingAddressPostZipCode: string;		    			
      status: InvoiceStatus;    	
      subTotal: number;    	
      tax: number;    	
      termsAndConditions : string;    	

					    customerCustomerId : number ;   
					    customerName : string;   


	  constructor() {
	  }
    }

